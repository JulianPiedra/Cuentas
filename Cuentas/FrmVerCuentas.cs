using BussinessLogic;
using DataAccess.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UILogic;

namespace Cuentas
{
    public partial class FrmVerCuentas : Form
    {
        private List<CuentaDAO> todasLasCuentas = new List<CuentaDAO>();

        public FrmVerCuentas()
        {
            InitializeComponent();
            DgvCuentas.CellClick += DgvCuentas_CellContentClick;
            cmbSemanal.SelectedIndex = 0;
            DgvCuentas.CellFormatting += DgvCuentas_CellFormatting;
        }

        private void DgvCuentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvCuentas.Columns[e.ColumnIndex].Name != "SiguientePago" || e.RowIndex < 0)
                return;

            var valorCelda = DgvCuentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            if (string.IsNullOrWhiteSpace(valorCelda) || valorCelda == "Cancelado")
                return;

            // Intentamos parsear la fecha como DateTime
            if (DateTime.TryParseExact(valorCelda, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture,
                                       System.Globalization.DateTimeStyles.None, out var fechaPago))
            {
                var hoy = DateTime.Today;

                if (fechaPago.Date == hoy)
                {
                    e.CellStyle.BackColor = System.Drawing.Color.LightBlue; // Hoy
                }
                else if (fechaPago.Date < hoy)
                {
                    e.CellStyle.BackColor = System.Drawing.Color.LightCoral; // Atrasado
                }
            }
        }
 


        public void RecargarDatos(IEnumerable<CuentaDAO> cuentas)
        {
            DgvCuentas.Rows.Clear();

            foreach (var item in cuentas)
            {
                DgvCuentas.Rows.Add(
                    item.Cuenta,
                    item.Cliente.Nombre,
                    item.Monto,
                    item.Cuotas,
                    item.Canceladas,
                    item.SiguientePago != DateOnly.MinValue
                        ? item.SiguientePago.ToString("dd-MM-yyyy")
                        : "Cancelado"
                );
            }
        }

        private async void FrmVerCuentas_Load(object sender, EventArgs e)
        {
            try
            {
                // Traer todos los datos solo una vez
                var response = await ApiFetch.FetchAsync<List<CuentaDAO>>("/cuentas/obtener", HttpMethod.Get, null);
                todasLasCuentas = response;

                RecargarDatos(todasLasCuentas);

                foreach (DataGridViewColumn column in DgvCuentas.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cuentas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var cuentaStr = DgvCuentas.Rows[e.RowIndex].Cells["Cuenta"].Value?.ToString();
            var siguientePagoStr = DgvCuentas.Rows[e.RowIndex].Cells["SiguientePago"].Value?.ToString();

            if (!int.TryParse(cuentaStr, out int cuentaId))
            {
                MessageBox.Show("No se pudo obtener el ID de la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // MULTA
            if (DgvCuentas.Columns[e.ColumnIndex].Name == "Multa")
            {
                if (siguientePagoStr == "Cancelado")
                {
                    MessageBox.Show("Cuenta ya ha sido cancelada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show(
                    "¿Está seguro de que desea multar el siguiente pago de esta cuenta?",
                    "Confirmar multa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DateOnly fechaSiguientePago = DateOnly.ParseExact(siguientePagoStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                        string fechaStr = fechaSiguientePago.ToString("yyyy-MM-dd");

                        var resultado = await ApiFetch.FetchAsync<string>($"/cuentas/{cuentaStr}/{fechaStr}/multar", HttpMethod.Patch);

                        MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecargarDatos(todasLasCuentas);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al multar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // VER PAGOS
            if (DgvCuentas.Columns[e.ColumnIndex].Name == "VerPagos")
            {
                try
                {
                    var listaPagos = await ApiFetch.FetchAsync<List<CuentaDAO>>($"/cuentas/{cuentaId}/pagos", HttpMethod.Get, null);
                    var frmVerPagos = new FrmVerPagos(listaPagos)
                    {
                        Owner = this
                    };
                    frmVerPagos.ShowDialog();
                    var response = await ApiFetch.FetchAsync<List<CuentaDAO>>("/cuentas/obtener", HttpMethod.Get, null);
                    todasLasCuentas = response;
                    RecargarDatos(todasLasCuentas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener los pagos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtBuscar.Text.ToLower();
            var filteredCuentas = todasLasCuentas
                .Where(c =>
                    c.Cliente.Nombre.ToLower().Contains(searchText) ||
                    (c.SiguientePago != DateOnly.MinValue &&
                     c.SiguientePago.ToString("dd-MM-yyyy").Contains(searchText)) ||
                     c.Cliente.Telefono.ToString().Contains(searchText) ||
                     c.IdCliente.ToLower().Contains(searchText))
                .ToList();

            RecargarDatos(filteredCuentas);
        }
        private void cmbSemanal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSemanal.SelectedIndex == 0)
            {
                RecargarDatos(todasLasCuentas);
                return;
            }

            var seleccion = cmbSemanal.SelectedItem.ToString();

            List<CuentaDAO> filteredCuentas;

            // Filtrar por día del mes
            if (seleccion == "15" || seleccion == "30")
            {
                int dia = int.Parse(seleccion);
                filteredCuentas = todasLasCuentas
                    .Where(c => c.SiguientePago != DateOnly.MinValue &&
                                c.SiguientePago.Day == dia)
                    .ToList();
            }
            else
            {
                // Filtrar por día de la semana
                var diaSemana = seleccion switch
                {
                    "Lunes" => DayOfWeek.Monday,
                    "Martes" => DayOfWeek.Tuesday,
                    "Miércoles" => DayOfWeek.Wednesday,
                    "Jueves" => DayOfWeek.Thursday,
                    "Viernes" => DayOfWeek.Friday,
                    "Sábado" => DayOfWeek.Saturday,
                    "Domingo" => DayOfWeek.Sunday,
                    _ => DateTime.Today.DayOfWeek
                };

                filteredCuentas = todasLasCuentas
                    .Where(c => c.SiguientePago != DateOnly.MinValue &&
                                c.SiguientePago.ToDateTime(TimeOnly.MinValue).DayOfWeek == diaSemana)
                    .ToList();
            }

            RecargarDatos(filteredCuentas);
        }


    }
}
