using System.Configuration;
using BussinessLogic;
using DataAccess;
using DataAccess.Models;
using Models;
using UILogic;

namespace Cuentas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //FrmOtp login = new FrmOtp();
            //if (login.ShowDialog() == DialogResult.OK)
            //{
                Application.Run(new FrmAdministradorDeCuentas());
            //}

        }
    }
}
