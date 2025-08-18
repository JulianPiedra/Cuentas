using ApiCuentasInjection;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BussinessLogic
{
    public class ClientesLogic : IClienteLogic
    {
        private readonly BdContext Context;
        public ClientesLogic(BdContext context)
        {
            Context = context;
        }

        public async Task<BusinessLogicResponse> AgregarCliente(ClienteDAO clienteDAO)
        {
            try
            {
                var clientes = Context.Clientes;
                bool clienteExistente = await clientes.AnyAsync(c => c.IdCliente == clienteDAO.IdCliente);
                if (clienteExistente)
                    return new BusinessLogicResponse(400, "Ya existe un cliente con esta cédula");

                var AddCliente = new Cliente
                {
                    IdCliente = clienteDAO.IdCliente,
                    Correo = clienteDAO.Correo,
                    Telefono = clienteDAO.Telefono,
                    Direccion = clienteDAO.Direccion,
                    Nombre = clienteDAO.Nombre
                };

                await clientes.AddAsync(AddCliente);

                if (clienteDAO.Files != null)
                {
                    var files = Context.Multimedia;
                    foreach (var file in clienteDAO.Files)
                    {
                        files.Add(new Multimedium
                        {
                            IdCliente = clienteDAO.IdCliente,
                            Multimedia = file.Value,
                            Extension = file.Key.Split('.').LastOrDefault() ?? string.Empty
                        });
                    }
                }

                await Context.SaveChangesAsync();

                return new BusinessLogicResponse(200, "Cliente agregado con éxito");
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al agregar cliente: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> AgregarMultimedia(string idCliente, Dictionary<string, byte[]> archivos)
        {
            try
            {
                if (archivos == null || archivos.Count == 0)
                    return new BusinessLogicResponse(400, "No se proporcionaron archivos multimedia.");

                var files = Context.Multimedia;

                foreach (var file in archivos)
                {
                    var extension = file.Key.Split('.').LastOrDefault() ?? string.Empty;

                    var multimedia = new Multimedium
                    {
                        IdCliente = idCliente,
                        Multimedia = file.Value,
                        Extension = extension
                    };

                    await files.AddAsync(multimedia);
                }

                await Context.SaveChangesAsync();

                return new BusinessLogicResponse(200, "Archivos multimedia agregados con éxito.");
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al agregar multimedia: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> ObtenerClientes()
        {
            try
            {
                var clientes = await Context.Clientes
                    .Include(c => c.Cuenta)
                    .AsNoTracking()
                    .ToListAsync();

                var clientesDAO = clientes.Select(c => new ClienteDAO
                {
                    IdCliente = c.IdCliente,
                    Correo = c.Correo,
                    Telefono = c.Telefono,
                    Direccion = c.Direccion,
                    Nombre = c.Nombre,
                    Cuentas = c.Cuenta.Select(cta => new CuentaDAO
                    {
                        Cuenta = cta.IdCuenta,
                        IdCliente = cta.IdCliente,
                        Monto = cta.Monto,
                        Cuotas = cta.Cuotas,
                        Canceladas = cta.Canceladas,
                        SiguientePago = cta.SiguientePago,
                        
                    }).ToList()
                }).ToList();

                return new BusinessLogicResponse(200, clientesDAO);
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al obtener los clientes: {ex.Message}");
            }
        }

        public async Task<BusinessLogicResponse> ObtenerClienteConMultimedia(string id)
        {
            try
            {
                var cliente = await Context.Clientes
                    .Where(c => c.IdCliente == id)
                    .Include(c => c.Cuenta)
                        .ThenInclude(cta => cta.PagoCuenta)
                    .Include(c => c.Multimedia)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                if (cliente == null)
                    return new BusinessLogicResponse(404, "Cliente no encontrado");

                var clienteDAO = new ClienteDAO
                {
                    IdCliente = cliente.IdCliente,
                    Correo = cliente.Correo,
                    Telefono = cliente.Telefono,
                    Direccion = cliente.Direccion,
                    Nombre = cliente.Nombre,
                    Files = cliente.Multimedia?.ToDictionary(
                        m => $"{m.IdMultimedia}.{m.Extension}",
                        m => m.Multimedia),
                    Cuentas = cliente.Cuenta.Select(cta => new CuentaDAO
                    {
                        Cuenta = cta.IdCuenta,
                        IdCliente = cta.IdCliente,
                        Monto = cta.Monto,
                        Cuotas = cta.Cuotas,
                        Canceladas = cta.Canceladas,
                        SiguientePago = cta.SiguientePago,
                    }).ToList()
                };

                return new BusinessLogicResponse(200, clienteDAO);
            }
            catch (Exception ex)
            {
                return new BusinessLogicResponse(500, $"Error al obtener el cliente: {ex.Message}");
            }
        }

        public Task<BusinessLogicResponse> EditarCliente(ClienteDAO clienteDAO)
        {
            return Task.FromResult(new BusinessLogicResponse(501, "Método aún no implementado"));
        }
    }
}
