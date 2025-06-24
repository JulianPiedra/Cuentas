using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
                var Addcuenta = new Cuentum
                {
                    IdCliente = cuentaDAO.IdCliente,
                    Monto = cuentaDAO.Monto,
                    Cuotas = cuentaDAO.Cuotas,
                };

                await cuenta.AddAsync(Addcuenta);
                await BdContext.Context.SaveChangesAsync();

                foreach (var pago in cuentaDAO.PagosCuenta)
                {
                    pagos.Add(new PagoCuentum
                    {
                        IdCuenta = Addcuenta.IdCuenta,
                        FechaPago = pago.FechaPago,
                        Cancelado = pago.Cancelado,
                        Monto = pago.Monto
                    });

                }

                await BdContext.Context.SaveChangesAsync();
                ListaCuentas.Add(await cuenta
                    .AsNoTracking()
                    .Include(c => c.IdClienteNavigation)
                    .FirstAsync(c => c.IdCuenta == Addcuenta.IdCuenta));
                return "Cuenta creada con exito";
            }
            catch (Exception ex)
            {
                var asd = ex.Message;
                throw new Exception("Error al agregar cuenta");
            }
        }


        public async static Task ObtenerCuentas()
        {
            try
            {
                if (!ListaCuentas.IsNullOrEmpty()) ListaCuentas.Clear();

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
        public async static Task ActualizarEstadoPago(int idCuenta, int idPago)
        {
            try
            {
                var pago = BdContext.Context.PagoCuenta
                    .FirstOrDefault(p => p.IdCuenta == idCuenta && p.IdPago == idPago);

                if (pago != null)
                {
                    pago.Cancelado = !pago.Cancelado;
                    await BdContext.Context.SaveChangesAsync(); 
                }

                var cuentaActualizada = await BdContext.Context.Cuenta
                    .AsNoTracking()
                    .Include(c => c.IdClienteNavigation)
                    .FirstAsync(c => c.IdCuenta == idCuenta);

                var index = ListaCuentas.FindIndex(c => c.IdCuenta == idCuenta);
                if (index != -1)
                {
                    ListaCuentas[index] = cuentaActualizada;
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al actualizar el estado del pago");
            }

        }


    }

}

