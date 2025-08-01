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
                // Cargar cuentas con navegación
                var cuentas = await BdContext.Context.Cuenta
                    .Include(c => c.IdClienteNavigation)
                    .Include(c => c.PagoCuenta)
                    .AsNoTracking()
                    .ToListAsync();

                // Cargar clientes
                var clientes = await BdContext.Context.Clientes
                    .AsNoTracking()
                    .ToListAsync();

                // Procesamiento de estadísticas
                var estadisticas = new Estadisticas
                {
                    TotalClientes = clientes.Count,
                    TotalCuentas = cuentas.Count,
                    TotalCuentasActivas = cuentas.Count(c => c.Cuotas != c.Canceladas),
                    MontoTotalCuentas = cuentas.Sum(c => c.Monto),
                    MontoTotalCuentasPendientes = cuentas.Sum(c =>
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
