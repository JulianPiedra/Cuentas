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
                var files = BdContext.Context.Multimedia;
                var AddCliente = new Cliente
                {
                    IdCliente = clienteDAO.IdCliente,
                    Correo = clienteDAO.Correo,
                    Telefono = clienteDAO.Telefono,
                    Direccion = clienteDAO.Direccion,
                    Nombre = clienteDAO.Nombre
                };
                clientes.AddAsync(AddCliente);
                if (clienteDAO.Files != null)
                {
                    foreach (var file in clienteDAO.Files)
                    {
                        files.AddAsync(new Multimedium
                        {
                            IdCliente = clienteDAO.IdCliente,
                            Multimedia = file.Value
                        });
                    }
                }
                 BdContext.Context.SaveChanges();
                ListaClientes.Add(AddCliente);
                return "Cliente agregado con exito";
            }
            catch (Exception)
            {
                throw new Exception("Error al agregar cliente"); 
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
