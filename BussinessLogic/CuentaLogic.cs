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
                var cuenta = new Cuentum
                {
                    IdCliente = cuentaDAO.IdCliente,
                    Monto = cuentaDAO.Monto,
                    Cuotas = cuentaDAO.Cuotas,
                    Canceladas = cuentaDAO.Canceladas,
                    SiguientePago = cuentaDAO.SiguientePago
                };

                await BdContext.Context.Cuenta.AddAsync(cuenta);
                await BdContext.Context.SaveChangesAsync(); 

                foreach (var pago in cuentaDAO.PagosCuenta)
                {
                    pagos.AddAsync(new PagoCuentum
                    {
                        IdCuenta = cuenta.IdCuenta,
                        FechaPago = pago.FechaPago,
                        Cancelado = pago.Cancelado
                    });

                }
                await BdContext.Context.SaveChangesAsync();




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
                ListaCuentas = cuenta.ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener los clientes");
            }
        }
    }

}

