using BussinessLogic;
using DataAccess.Models;
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
        }

        public void RecargarDatos(IEnumerable<object> cuentas)
        {
            var source = new BindingSource
            {
                DataSource = cuentas
            };
            DgvCuentas.DataSource = source;
            

            if (!DgvCuentas.Columns.Contains("VerPagos"))
            {
                if (DgvCuentas.Columns.Contains("SiguientePago"))
                    DgvCuentas.Columns["SiguientePago"].HeaderText = "Siguiente Pago";

                if (DgvCuentas.Columns.Contains("Cuenta"))
                    DgvCuentas.Columns["Cuenta"].Visible = false;

                DgvCuentas.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "Multa",
                    Text = "Multar cuenta",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "Multa"
                });
                

                DgvCuentas.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "VerPagos",
                    Text = "Ver Pagos",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "Pagos"
                });

               
            }
        }

        private void FrmVerCuentas_Load(object sender, EventArgs e)
        {
            CargarTodasLasCuentas();
        }

        private void CargarTodasLasCuentas()
        {
            var cuentas = CuentaLogic.ListaCuentas
                .Select(c => new
                {
                    Cuenta = c.IdCuenta,
                    Cliente = c.IdClienteNavigation.Nombre,
                    c.Monto,
                    c.Cuotas,
                    c.Canceladas,
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
                    if(siguientePago == "Cancelado")
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
                        try {
                            DateOnly fechaSiguientePago = DateOnly.ParseExact(siguientePago, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                            var resultado = await CuentaLogic.MultarCuenta(cuentaId,fechaSiguientePago);
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

            var filteredCuentas = CuentaLogic.ListaCuentas
                .Where(c =>
                    c.IdClienteNavigation.Nombre.ToLower().Contains(searchText) ||
                    c.SiguientePago.ToString("dd-MM-yyyy").Contains(searchText) ||
                    (c.SiguientePago == DateOnly.MinValue && "cancelado".Contains(searchText))
                )
                .Select(c => new
                {
                    Cuenta = c.IdCuenta,
                    Cliente = c.IdClienteNavigation.Nombre,
                    c.Monto,
                    c.Cuotas,
                    c.Canceladas,
                    SiguientePago = c.SiguientePago != DateOnly.MinValue
                        ? c.SiguientePago.ToString("dd-MM-yyyy")
                        : "Cancelado"
                })
                .ToList();

            RecargarDatos(filteredCuentas);
        }


        private void cbPagosHoy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPagosHoy.Checked)
            {
                var hoy = DateOnly.FromDateTime(DateTime.Today);
                var filteredCuentas = CuentaLogic.ListaCuentas
                    .Where(c => c.SiguientePago == hoy)
                    .Select(c => new
                    {
                        Cuenta = c.IdCuenta,
                        Cliente = c.IdClienteNavigation.Nombre,
                        c.Monto,
                        c.Cuotas,
                        c.Canceladas,
                        SiguientePago = c.SiguientePago != DateOnly.MinValue
                            ? c.SiguientePago.ToString("dd-MM-yyyy")
                            : "Cancelado"
                    })
                    .ToList();

                RecargarDatos(filteredCuentas);
            }
            else
            {
                CargarTodasLasCuentas();
            }
        }
    }
}
