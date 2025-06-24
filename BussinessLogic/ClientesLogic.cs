using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BussinessLogic
{
    public class ClientesLogic
    {
        public static List<Cliente> ListaClientes { get; set; }

        public string AgregarCliente(ClienteDAO clienteDAO)
        {
            
            try
            {
                var clientes = BdContext.Context.Clientes;
                if (clientes.FirstOrDefault(c => c.IdCliente == clienteDAO.IdCliente) != null)
                    throw new Exception("Ya existe un cliente con esta cédula");
                var files = BdContext.Context.Multimedia;
                var AddCliente = new Cliente
                {
                    IdCliente = clienteDAO.IdCliente,
                    Correo = clienteDAO.Correo,
                    Telefono = clienteDAO.Telefono,
                    Direccion = clienteDAO.Direccion,
                    Nombre = clienteDAO.Nombre
                };
                clientes.Add(AddCliente);

                if (clienteDAO.Files != null)
                {
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
                BdContext.Context.SaveChanges();

                ListaClientes.Add(AddCliente);
                return "Cliente agregado con exito";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar cliente: "+ ex.Message); 
            }

        }

        public async static Task ObtenerClientes()
        {
            try
            {
                var clientes = BdContext.Context.Clientes;
                clientes.Include(c => c.Cuenta)
                        .Include(c => c.Multimedia)
                        .AsNoTracking();
                ListaClientes =  clientes.ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener los clientes");
            }
        }

    }
}
