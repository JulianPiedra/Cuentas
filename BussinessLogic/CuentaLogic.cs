using ApiCuentasInjection;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BussinessLogic
{
    public class CuentaLogic : ICuentaLogic
    {
        private readonly BdContext Context;
        public CuentaLogic(BdContext context)
        {
            Context = context;
        }

        public async Task<BusinessLogicResponse> MultarCuenta(int idCuenta, DateOnly fechaPago)
        {
            try
            {
                var pago = await Context.PagoCuenta
                    .FirstOrDefaultAsync(p => p.IdCuenta == idCuenta && p.FechaPago == fechaPago);

                if (pago == null)
                    return new BusinessLogicResponse(404, "No se encontró un pago con la fecha especificada.");

                pago.Multa += 1;
                pago.Monto += 5000;

                var cuenta = await Context.Cuenta
                    .FirstOrDefaultAsync(c => c.IdCuenta == idCuenta);

                if (cuenta == null)
                    return new BusinessLogicResponse(404, "Cuenta no encontrada.");

                cuenta.Monto += 5000;

                await Context.SaveChangesAsync();

                return new BusinessLogicResponse(200, "La cuenta ha sido multada");
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al multar la cuenta: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> AgregarCuenta(CuentaDAO cuentaDAO)
        {
            try
            {
                var nuevaCuenta = new Cuentum
                {
                    IdCliente = cuentaDAO.IdCliente,
                    Monto = cuentaDAO.Monto,
                    Cuotas = cuentaDAO.Cuotas,
                    Canceladas = cuentaDAO.Canceladas,
                    IdTipoCuenta = cuentaDAO.TipoCuenta.IdTipoCuenta,
                    IdTipoPago = cuentaDAO.TipoPago.IdTipoPago,
                };

                await Context.Cuenta.AddAsync(nuevaCuenta);
                await Context.SaveChangesAsync();

                foreach (var pago in cuentaDAO.PagosCuenta)
                {
                    await Context.PagoCuenta.AddAsync(new PagoCuentum
                    {
                        IdCuenta = nuevaCuenta.IdCuenta,
                        FechaPago = pago.FechaPago,
                        Cancelado = pago.Cancelado,
                        Monto = pago.Monto
                    });
                }
                await Context.SaveChangesAsync();

                nuevaCuenta.SiguientePago = await Context.PagoCuenta
                    .Where(p => p.IdCuenta == nuevaCuenta.IdCuenta && !p.Cancelado)
                    .OrderBy(p => p.FechaPago)
                    .Select(p => p.FechaPago)
                    .FirstOrDefaultAsync();

                await Context.SaveChangesAsync();

                return new BusinessLogicResponse(200, "Cuenta creada con éxito");
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al agregar cuenta: {ex.Message}");
            }
        }


        public async Task<BusinessLogicResponse> ObtenerCuentas()
        {
            try
            {
                var cuentas = await Context.Cuenta
                    .Include(c => c.IdClienteNavigation)
                    .Include(c => c.IdTipoCuentaNavigation)
                    .Include(c => c.IdTipoPagoNavigation)
                    .AsNoTracking()
                    .ToListAsync();

                var cuentasDAO = cuentas.Select(c => new CuentaDAO
                {
                    Cuenta = c.IdCuenta,
                    IdCliente = c.IdCliente,
                    Monto = c.Monto,
                    Cuotas = c.Cuotas,
                    Canceladas = c.Canceladas,
                    SiguientePago = c.SiguientePago,
                    Cliente = new ClienteDAO
                    {
                        IdCliente = c.IdClienteNavigation.IdCliente,
                        Correo = c.IdClienteNavigation.Correo,
                        Telefono = c.IdClienteNavigation.Telefono,
                        Direccion = c.IdClienteNavigation.Direccion,
                        Nombre = c.IdClienteNavigation.Nombre
                    },
                    TipoCuenta = new TipoCuentaDAO
                    {
                        IdTipoCuenta = c.IdTipoCuentaNavigation?.IdTipoCuenta,
                        Nombre = c.IdTipoCuentaNavigation?.Nombre
                    },
                    TipoPago = new TipoPagoDAO
                    {
                        IdTipoPago = c.IdTipoPagoNavigation?.IdTipoPago,
                        Nombre = c.IdTipoPagoNavigation?.Nombre
                    }

                }).ToList();

                return new BusinessLogicResponse(200, cuentasDAO);
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al obtener cuentas: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> ObtenerCuentasConPagos(int id)
        {
            try
            {
                var cuentas = await Context.Cuenta
                    .Where(c => c.IdCuenta == id)
                    .Include(c => c.IdClienteNavigation)
                    .Include(c => c.IdTipoCuentaNavigation)
                    .Include(c => c.IdTipoPagoNavigation)
                    .Include(c => c.PagoCuenta)
                    .AsNoTracking()
                    .ToListAsync();

                var cuentasDAO = cuentas.Select(c => new CuentaDAO
                {
                    Cuenta = c.IdCuenta,
                    IdCliente = c.IdCliente,
                    Monto = c.Monto,
                    Cuotas = c.Cuotas,
                    Canceladas = c.Canceladas,
                    SiguientePago = c.SiguientePago,
                    Cliente = new ClienteDAO
                    {
                        IdCliente = c.IdClienteNavigation.IdCliente,
                        Correo = c.IdClienteNavigation.Correo,
                        Telefono = c.IdClienteNavigation.Telefono,
                        Direccion = c.IdClienteNavigation.Direccion,
                        Nombre = c.IdClienteNavigation.Nombre
                    },
                    PagosCuenta = c.PagoCuenta.Select(p => new PagoCuentaDAO
                    {
                        IdCuenta = p.IdCuenta,
                        IdPago = p.IdPago,
                        FechaPago = p.FechaPago,
                        Cancelado = p.Cancelado,
                        Monto = p.Monto,
                        Multa = p.Multa
                    }).ToList(),
                    TipoCuenta = new TipoCuentaDAO
                    {
                        IdTipoCuenta = c.IdTipoCuentaNavigation?.IdTipoCuenta,
                        Nombre = c.IdTipoCuentaNavigation?.Nombre
                    },
                    TipoPago = new TipoPagoDAO
                    {
                        IdTipoPago = c.IdTipoPagoNavigation?.IdTipoPago,
                        Nombre = c.IdTipoPagoNavigation?.Nombre
                    }
                }).ToList();

                return new BusinessLogicResponse(200, cuentasDAO);
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al obtener cuentas con pagos: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> ActualizarEstadoPago(int idCuenta, int idPago)
        {
            try
            {
                var pago = await Context.PagoCuenta
                    .FirstOrDefaultAsync(p => p.IdCuenta == idCuenta && p.IdPago == idPago);
                var cuenta = await Context.Cuenta
                    .FirstOrDefaultAsync(p => p.IdCuenta == idCuenta);

                if (pago == null)
                    return new BusinessLogicResponse(404, "Pago no encontrado.");

                pago.Cancelado = !pago.Cancelado;
                await Context.SaveChangesAsync();

                cuenta.SiguientePago = await Context.PagoCuenta
                    .Where(p => p.IdCuenta == idCuenta && !p.Cancelado)
                    .OrderBy(p => p.FechaPago)
                    .Select(p => p.FechaPago)
                    .FirstOrDefaultAsync();
                cuenta.Canceladas += 1;
                await Context.SaveChangesAsync();
                
                return new BusinessLogicResponse(200, "Estado del pago actualizado");
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al actualizar el estado del pago: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> EditarCuenta(CuentaDAO cuentaDAO)
        {
            // Obtener todos los pagos existentes de la cuenta
            var pagosExistentes = await Context.PagoCuenta
                .Where(p => p.IdCuenta == cuentaDAO.Cuenta)
                .ToListAsync();

            if (pagosExistentes.Count == 0)
            {
                return new BusinessLogicResponse(404, "No se encontraron pagos para la cuenta especificada.");
            }

            try
            {
                var cuenta = await Context.Cuenta
                    .FirstOrDefaultAsync(c => c.IdCuenta == cuentaDAO.Cuenta);

               

                if (cuenta == null)
                {
                    return new BusinessLogicResponse(404, "Cuenta no encontrada.");
                }



                // Actualizar los datos de la cuenta
                cuenta.IdCliente = cuentaDAO.IdCliente;
                cuenta.Cuotas = cuentaDAO.Cuotas;
                cuenta.Canceladas = cuentaDAO.Canceladas;
                cuenta.IdTipoCuenta = cuentaDAO.TipoCuenta.IdTipoCuenta;
                cuenta.IdTipoPago = cuentaDAO.TipoPago.IdTipoPago;

                // Borrar todos los pagos existentes
                Context.PagoCuenta.RemoveRange(pagosExistentes);

                // Agregar los pagos nuevos
                if (cuentaDAO.PagosCuenta != null && cuentaDAO.PagosCuenta.Any())
                {
                    foreach (var pagoDAO in cuentaDAO.PagosCuenta)
                    {
                        decimal Monto;
                        if (pagoDAO.Multa > 0)
                        {
                            Monto = pagoDAO.Monto+ ( 5000 * pagoDAO.Multa);
                        }
                        else
                        {
                            Monto = pagoDAO.Monto;
                        }
                        var nuevoPago = new PagoCuentum
                        {
                            IdCuenta = cuenta.IdCuenta,
                            FechaPago = pagoDAO.FechaPago,
                            Cancelado = pagoDAO.Cancelado,
                            Monto = Monto,
                            Multa = pagoDAO.Multa
                        };
                        await Context.PagoCuenta.AddAsync(nuevoPago);
                    }
                }
                cuenta.Monto = cuentaDAO.PagosCuenta.Sum(p => p.Monto + (p.Multa > 0 ? 5000 * p.Multa : 0));

                ;

                cuenta.SiguientePago = await Context.PagoCuenta
                    .Where(p => p.IdCuenta == cuenta.IdCuenta && !p.Cancelado)
                    .OrderBy(p => p.FechaPago)
                    .Select(p => p.FechaPago)
                    .FirstOrDefaultAsync();

                await Context.SaveChangesAsync();

                return new BusinessLogicResponse(200, "Cuenta editada con éxito");
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al editar la cuenta: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> ObtenerTipoCuentas()
        {
            try
            {
                var tipoCuenta = await Context.TipoCuenta
                    .AsNoTracking()
                    .ToListAsync();

                var cuentasDAO = tipoCuenta.Select(c => new TipoCuentaDAO
                {
                    IdTipoCuenta = c.IdTipoCuenta,
                    Nombre = c.Nombre
                }).ToList();

                return new BusinessLogicResponse(200, cuentasDAO);
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al obtener tipos de cuenta: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> ObtenerTipoPagoCuentas()
        {
            try
            {
                var tipoPago = await Context.TipoPagos
                    .AsNoTracking()
                    .ToListAsync();

                var cuentasDAO = tipoPago.Select(c => new TipoPagoDAO
                {
                    IdTipoPago = c.IdTipoPago,
                    Nombre = c.Nombre
                }).ToList();

                return new BusinessLogicResponse(200, cuentasDAO);
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al obtener tipos de pagos: {ex.Message}");
            }
        }
    }
}
