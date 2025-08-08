using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCuentasInjection
{
    public interface IEstadisticasLogic
    {
        Task<BusinessLogicResponse> ObtenerTotalClientes();
        Task<BusinessLogicResponse> ObtenerTotalCuentas();
        Task<BusinessLogicResponse> ObtenerTotalCuentasActivas();
        Task<BusinessLogicResponse> ObtenerMontoTotalCuentas();
        Task<BusinessLogicResponse> ObtenerMontoTotalCuentasPendientes();

    }
}
