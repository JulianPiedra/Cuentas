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
            Application.Run(new FrmAdministradorDeCuentas());
        }
    }
}
