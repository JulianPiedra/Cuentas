 using ApiCuentasInjection;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BussinessLogic
{
    public class EstadisticasLogic : IEstadisticasLogic
    {
        private readonly BdContext Context;
        public EstadisticasLogic(BdContext context)
        {
            Context = context;
        }
        public async Task<BusinessLogicResponse> ObtenerTotalClientes()
        {
            try
            {
                var total = await Context.Clientes
                    .AsNoTracking()
                    .CountAsync();

                return new BusinessLogicResponse(200, total);
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al obtener total de clientes: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> ObtenerTotalCuentas()
        {
            try
            {
                var total = await Context.Cuenta
                    .AsNoTracking()
                    .CountAsync();

                return new BusinessLogicResponse(200, total);
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al obtener total de cuentas: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> ObtenerTotalCuentasActivas()
        {
            try
            {
                var total = await Context.Cuenta
                    .AsNoTracking()
                    .CountAsync(c => c.Cuotas != c.Canceladas);

                return new BusinessLogicResponse(200, total);
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al obtener total de cuentas activas: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> ObtenerMontoTotalCuentas()
        {
            try
            {
                var total = await Context.Cuenta
                    .AsNoTracking()
                    .SumAsync(c => c.Monto);

                return new BusinessLogicResponse(200, total);
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al obtener monto total de cuentas: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> ObtenerMontoTotalCuentasPendientes()
        {
            try
            {
                var cuentas = await Context.Cuenta
                    .Include(c => c.PagoCuenta)
                    .AsNoTracking()
                    .ToListAsync();

                var montoPendiente = cuentas.Sum(c =>
                    c.Monto - c.PagoCuenta.Where(p => p.Cancelado).Sum(p => p.Monto));

                return new BusinessLogicResponse(200, montoPendiente);
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al obtener monto pendiente: {ex.Message}");
            }
        }
    }
}
