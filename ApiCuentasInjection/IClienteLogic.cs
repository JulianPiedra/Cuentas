using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCuentasInjection
{
    public interface IClienteLogic
    {
        Task<BusinessLogicResponse> AgregarCliente(ClienteDAO clienteDAO);
        Task<BusinessLogicResponse> EditarCliente(ClienteDAO clienteDAO);
        Task<BusinessLogicResponse> ObtenerClientes();
        Task<BusinessLogicResponse> ObtenerClienteConMultimedia(string id);
        Task<BusinessLogicResponse> AgregarMultimedia(string idCliente, Dictionary<string, byte[]> archivos);
    }
}
