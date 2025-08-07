using BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuentas
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private async void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            try
            {
                var estadisticas = await EstadisticasLogic.ObtenerEstadisticas();

                lblTotalClientes.Text = "Clientes Totales: \n" + estadisticas.TotalClientes.ToString();
                lblTotalCuentas.Text = "Cuentas Totales: \n" + estadisticas.TotalCuentas.ToString();
                lblTotalCuentasActivas.Text = "Total de cuentas activas: \n" + estadisticas.TotalCuentasActivas.ToString();
                lblMontoTotalCuentas.Text = "Monto total de cuentas: \n" + estadisticas.MontoTotalCuentas.ToString("C2");
                lblMontoTotalCuentasPendientes.Text = "Plata en la calle: \n" + estadisticas.MontoTotalCuentasPendientes.ToString("C2");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las estadísticas: " + ex.Message);
            }

        }
    }
}
