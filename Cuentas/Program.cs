using System.Configuration;
using BussinessLogic;
using DataAccess;
using DataAccess.Models;

namespace Cuentas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
             
            string connStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            BdContext.Initialize(connStr);
            Task.WhenAll(
                ClientesLogic.ObtenerClientes(),
                CuentaLogic.ObtenerCuentas()
            );
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmOtp login = new FrmOtp();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmAdministradorDeCuentas());
            }

        }
    }
}
