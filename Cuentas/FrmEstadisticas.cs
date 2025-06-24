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
                lblTotalClientes.Text = estadisticas.TotalClientes.ToString();
                lblTotalCuentas.Text = estadisticas.TotalCuentas.ToString();
                lblTotalCuentasActivas.Text = estadisticas.TotalCuentasActivas.ToString();
                lblMontoTotalCuentas.Text = estadisticas.MontoTotalCuentas.ToString("C2");
                lblMontoTotalCuentasPendientes.Text = estadisticas.MontoTotalCuentasPendientes.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las estadísticas: " + ex.Message);
            }

        }
    }
}
