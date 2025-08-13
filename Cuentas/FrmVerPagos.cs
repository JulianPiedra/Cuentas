using BussinessLogic;
using DataAccess.Models;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UILogic;

namespace Cuentas
{
    public partial class FrmVerPagos : Form
    {
        List<CuentaDAO> _cuentum;
        public FrmVerPagos(List<CuentaDAO> cuentum)
        {
            InitializeComponent();
            _cuentum = cuentum;
        }

        private void FrmVerPagos_Load(object sender, EventArgs e)
        {
            ActualizarVista();

        }

        private async void DgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                if (DgvPagos.Rows[e.RowIndex].ReadOnly) return;

                if (DgvPagos.Columns[e.ColumnIndex].Name == "Pagado")
                {
                    var idPago = Convert.ToInt32(DgvPagos.Rows[e.RowIndex].Cells["IdPago"].Value);

                    var listaPagos = await ApiFetch.FetchAsync<List<CuentaDAO>>($"/cuentas/{_cuentum[0].Cuenta}/pago/{idPago}/estado", HttpMethod.Get, null);

                    var cuentaActualizada = await ApiFetch.FetchAsync<List<CuentaDAO>>($"/cuentas/{_cuentum[0].Cuenta}/pagos", HttpMethod.Get, null);
                    _cuentum = cuentaActualizada;

                    ActualizarVista();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void ActualizarVista()
        {
            try
            {
                lblCanceladas.Text = "Cuotas canceladas: " + _cuentum[0].Canceladas.ToString();
                lblCuotas.Text = "Numero total de cuotas: " + _cuentum[0].Cuotas.ToString();
                lblMonto.Text = "Monto total: " + _cuentum[0].Monto.ToString("C2");
                lblSiguientePago.Text = "Siguiente pago: " + _cuentum[0].SiguientePago.ToString("dd/MM/yyyy") ?? "N/A";
                lblCliente.Text = "Nombre: " + _cuentum[0].Cliente[0].Nombre;

                DgvPagos.Rows.Clear();

                foreach (var pago in _cuentum[0].PagoCuenta)
                {
                    int rowIndex = DgvPagos.Rows.Add(
                        pago.IdPago,
                        $"{pago.FechaPago:dd/MM/yyyy} - ₡{pago.Monto:N2}",
                        pago.Cancelado
                    );
                    if (pago.Multa)
                    {
                        DgvPagos.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                        DgvPagos.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

                    }
                    if (pago.Cancelado)
                    {
                        DgvPagos.Rows[rowIndex].ReadOnly = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

