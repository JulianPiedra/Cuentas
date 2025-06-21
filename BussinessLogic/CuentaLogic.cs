using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BussinessLogic
{
    public class CuentaLogic
    {
        public static List<Cuentum> ListaCuentas { get; set; }

        public static async Task<string> AgregarCuenta(CuentaDAO cuentaDAO)
        {
            try
            {
                var pagos = BdContext.Context.PagoCuenta;
                var cuenta = BdContext.Context.Cuenta;
                cuenta.Include(cuenta => cuenta.IdClienteNavigation).AsNoTracking();
                var Addcuenta = new Cuentum
                {
                    IdCliente = cuentaDAO.IdCliente,
                    Monto = cuentaDAO.Monto,
                    Cuotas = cuentaDAO.Cuotas,
                    Canceladas = cuentaDAO.Canceladas,
                    SiguientePago = cuentaDAO.SiguientePago
                };

                await cuenta.AddAsync(Addcuenta);
                await BdContext.Context.SaveChangesAsync();

                foreach (var pago in cuentaDAO.PagosCuenta)
                {
                    pagos.AddAsync(new PagoCuentum
                    {
                        IdCuenta = Addcuenta.IdCuenta,
                        FechaPago = pago.FechaPago,
                        Cancelado = pago.Cancelado
                    });

                }

                await BdContext.Context.SaveChangesAsync();
                ListaCuentas.Add(Addcuenta);
                return "Cuenta creada con exito";
            }
            catch (Exception)
            {
                throw new Exception("Error al agregar cuenta");
            }
        }


        public async static Task ObtenerCuentas()
        {
            try
            {
                var cuenta = BdContext.Context.Cuenta;
                cuenta.Include(c => c.IdClienteNavigation)
                      .AsNoTracking();
                ListaCuentas = cuenta.ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener los clientes");
            }
        }
        public async static Task<List<Cuentum>> ObtenerCuentasConPagos(int id)
        {
            try
            {

                var cuenta = BdContext.Context.Cuenta
                    .Where(c => c.IdCuenta == id)
                      .Include(c => c.IdClienteNavigation)
                      .Include(c => c.PagoCuenta)
                      .AsNoTracking();

                return await cuenta.ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener las cuentas con pagos");
            }
        }
    }

}

