using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCuentasInjection
{
    public interface ICuentaLogic
    {
        Task<BusinessLogicResponse> AgregarCuenta(CuentaDAO cuentaDAO);
        Task<BusinessLogicResponse> EditarCuenta(CuentaDAO cuentaDAO);
        Task<BusinessLogicResponse> ObtenerCuentas();

        Task<BusinessLogicResponse> MultarCuenta(int idCuenta, DateOnly fechaPago);
        Task<BusinessLogicResponse> ActualizarEstadoPago(int idCuenta, int idPago);
        Task<BusinessLogicResponse> ObtenerCuentasConPagos(int id);
    }
}
