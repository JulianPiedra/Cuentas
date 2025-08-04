using BussinessLogic;
using DataAccess.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cuentas
{
    public partial class FrmVerCuentas : Form
    {
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
                    item.IdCliente,
                    item.Monto,
                    item.Cuotas,
                    item.Canceladas,
                    item.SiguientePago
                );
            }
        }


        private void FrmVerCuentas_Load(object sender, EventArgs e)
        {
            CargarTodasLasCuentas();
            foreach (DataGridViewColumn column in DgvCuentas.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void CargarTodasLasCuentas()
        {
            List<CuentaDAO> cuentas = CuentaLogic.ListaCuentas
                .Select(c => new CuentaDAO
                {
                    Cuenta = c.IdCuenta,
                    IdCliente = c.IdClienteNavigation.Nombre,
                    Monto = c.Monto,
                    Cuotas = c.Cuotas,
                    Canceladas = c.Canceladas,
                    SiguientePago = c.SiguientePago != DateOnly.MinValue
                        ? c.SiguientePago.ToString("dd-MM-yyyy")
                        : "Cancelado",

                })
                .ToList();

            RecargarDatos(cuentas);
        }

        private async void DgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var cuenta = DgvCuentas.Rows[e.RowIndex].Cells["Cuenta"].Value?.ToString();
            var siguientePago = DgvCuentas.Rows[e.RowIndex].Cells["SiguientePago"].Value?.ToString();

            if (DgvCuentas.Columns[e.ColumnIndex].Name == "Multa")
            {
                if (int.TryParse(cuenta, out int cuentaId))
                {
                    if (siguientePago == "Cancelado")
                    {
                        MessageBox.Show("Cuenta ya ha sido cancelada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    DialogResult result = MessageBox.Show(
                        "¿Está seguro de que desea multar el siguiente pago de esta cuenta?",
                        "Confirmar multa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            DateOnly fechaSiguientePago = DateOnly.ParseExact(siguientePago, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                            var resultado = await CuentaLogic.MultarCuenta(cuentaId, fechaSiguientePago);
                            MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarTodasLasCuentas();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al multar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID de la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (DgvCuentas.Columns[e.ColumnIndex].Name == "VerPagos")
            {
                if (int.TryParse(cuenta, out int cuentaId))
                {
                    var listaPagos = await CuentaLogic.ObtenerCuentasConPagos(cuentaId);

                    var frmVerPagos = new FrmVerPagos(listaPagos)
                    {
                        Owner = this
                    };
                    frmVerPagos.ShowDialog();

                    CargarTodasLasCuentas();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID de la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtBuscar.Text.ToLower();
            List<CuentaDAO> filteredCuentas = CuentaLogic.ListaCuentas
                .Where(c => c.IdClienteNavigation.Nombre.ToLower().Contains(searchText) 
                            || c.SiguientePago.ToString("dd-MM-yyyy").Contains(searchText) 
                            || c.IdCliente.ToLower().Contains(searchText)
                            || c.IdClienteNavigation.Telefono.ToString().Contains(searchText))
                .Select(c => new CuentaDAO
                {
                    Cuenta = c.IdCuenta,
                    IdCliente = c.IdClienteNavigation.Nombre,
                    Monto = c.Monto,
                    Cuotas = c.Cuotas,
                    Canceladas = c.Canceladas,
                    SiguientePago = c.SiguientePago != DateOnly.MinValue
                        ? c.SiguientePago.ToString("dd-MM-yyyy")
                        : "Cancelado"
                })
                .ToList();

            RecargarDatos(filteredCuentas);
        }


        private DateTime ObtenerFechaSemanaSeleccionada()
        {
            if (cmbSemanal.SelectedItem == null)
                return DateTime.Today;

            var seleccion = cmbSemanal.SelectedItem.ToString();

            if (seleccion == "15")
                return new DateTime(DateTime.Today.Year, DateTime.Today.Month, 15);

            if (seleccion == "30")
                return new DateTime(DateTime.Today.Year, DateTime.Today.Month, 30);

            var diaSemana = seleccion switch
            {
                "Lunes" => DayOfWeek.Monday,
                "Martes" => DayOfWeek.Tuesday,
                "Miercoles" => DayOfWeek.Wednesday,
                "Jueves" => DayOfWeek.Thursday,
                "Viernes" => DayOfWeek.Friday,
                "Sabado" => DayOfWeek.Saturday,
                "Domingo" => DayOfWeek.Sunday,
                _ => DateTime.Today.DayOfWeek
            };

            var hoy = DateTime.Today;
            int diasDiferencia = ((int)diaSemana - (int)hoy.DayOfWeek + 7) % 7;

            return hoy.AddDays(diasDiferencia == 0 ? 0 : diasDiferencia);
        }

        private void cmbSemanal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSemanal.SelectedIndex == 0)
            {
                CargarTodasLasCuentas();
                return;
            }
            List<CuentaDAO> filteredCuentas = CuentaLogic.ListaCuentas
                .Where(c => c.SiguientePago == DateOnly.FromDateTime(ObtenerFechaSemanaSeleccionada()))
                .Select(c => new CuentaDAO
                {
                    Cuenta = c.IdCuenta,
                   IdCliente = c.IdClienteNavigation.Nombre,
                    Monto = c.Monto,
                    Cuotas = c.Cuotas,
                    Canceladas = c.Canceladas,
                    SiguientePago = c.SiguientePago != DateOnly.MinValue
                        ? c.SiguientePago.ToString("dd-MM-yyyy")
                        : "Cancelado"
                })
                .ToList();

            RecargarDatos(filteredCuentas);

        }
    }
}
