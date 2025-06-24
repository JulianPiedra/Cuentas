using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BussinessLogic
{
    public class EstadisticasLogic
    {
        public static List<Estadisticas> ListaEstadisticas { get; set; }

        public static async Task<Estadisticas> ObtenerEstadisticas()
        {

            try
            {
                var cuentas = BdContext.Context.Cuenta
                    .Include(c => c.IdClienteNavigation)
                    .Include(c => c.PagoCuenta)
                    .AsNoTracking();
                var clientes = BdContext.Context.Clientes.ToList();

                var cuentasLista = cuentas.ToList();

                var estadisticas = new Estadisticas
                {
                    TotalClientes = clientes.Count(),
                    TotalCuentas = cuentasLista.Count(),
                    TotalCuentasActivas = cuentasLista.Count(c => c.Cuotas != c.Canceladas),
                    MontoTotalCuentas = cuentasLista.Sum(c => c.Monto),
                    MontoTotalCuentasPendientes = cuentasLista.Sum(c =>
                        c.Monto - c.PagoCuenta.Where(p => p.Cancelado).Sum(p => p.Monto))
                }; 

                return estadisticas;
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener estadísticas");
            }

        }



    }
}
