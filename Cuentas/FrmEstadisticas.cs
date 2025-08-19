using UILogic;
using Models;

namespace Cuentas
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private async Task<Estadisticas> ObtenerEstadisticas()
        {
            try
            {
                // Crear las tareas
                var taskTotalClientes = ApiFetch.FetchAsync<int>("/estadisticas/total-clientes", HttpMethod.Get);
                var taskTotalCuentas = ApiFetch.FetchAsync<int>("/estadisticas/total-cuentas", HttpMethod.Get);
                var taskTotalCuentasActivas = ApiFetch.FetchAsync<int>("/estadisticas/total-cuentas-activas", HttpMethod.Get);
                var taskMontoTotalCuentas = ApiFetch.FetchAsync<decimal>("/estadisticas/monto-total-cuentas", HttpMethod.Get);
                var taskMontoTotalCuentasPendientes = ApiFetch.FetchAsync<decimal>("/estadisticas/monto-pendiente-cuentas", HttpMethod.Get);

                // Esperar todas las tareas al mismo tiempo
                await Task.WhenAll(taskTotalClientes, taskTotalCuentas, taskTotalCuentasActivas, taskMontoTotalCuentas, taskMontoTotalCuentasPendientes);

                // Asignar los resultados
                var estadisticas = new Estadisticas
                {
                    TotalClientes = taskTotalClientes.Result,
                    TotalCuentas = taskTotalCuentas.Result,
                    TotalCuentasActivas = taskTotalCuentasActivas.Result,
                    MontoTotalCuentas = taskMontoTotalCuentas.Result,
                    MontoTotalCuentasPendientes = taskMontoTotalCuentasPendientes.Result
                };

                return estadisticas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las estadísticas: " + ex.Message);
                return null;
            }
        }



        private async void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            try
            {
                var estadisticas = await ObtenerEstadisticas();

                if (estadisticas != null)
                {
                    lblTotalClientes.Text = $"Clientes Totales: \n{estadisticas.TotalClientes}";
                    lblTotalCuentas.Text = $"Cuentas Totales: \n{estadisticas.TotalCuentas}";
                    lblTotalCuentasActivas.Text = $"Cuentas Activas: \n{estadisticas.TotalCuentasActivas}";
                    lblMontoTotalCuentas.Text = $"Monto Total de Cuentas: \n{estadisticas.MontoTotalCuentas:C2}";
                    lblMontoTotalCuentasPendientes.Text = $"Monto Pendiente de Cuentas: \n{estadisticas.MontoTotalCuentasPendientes:C2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estadísticas: " + ex.Message);
            }
        }
    }
}
