using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using BussinessLogic;
using ApiCuentasInjection;
using Models;
using CuentasApi;

public static class EstadisticasEndpoints
{
    public static void MapEstadisticasEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/estadisticas").WithTags(nameof(Estadisticas));

        group.MapGet("/total-clientes", async (IEstadisticasLogic logic) =>
        {
            var response = await logic.ObtenerTotalClientes();
            return Responses.ConvertToHttpResult(response);
        }).WithName("TotalClientes");

        group.MapGet("/total-cuentas", async (IEstadisticasLogic logic) =>
        {
            var response = await logic.ObtenerTotalCuentas();
            return Responses.ConvertToHttpResult(response);
        }).WithName("TotalCuentas");

        group.MapGet("/total-cuentas-activas", async (IEstadisticasLogic logic) =>
        {
            var response = await logic.ObtenerTotalCuentasActivas();
            return Responses.ConvertToHttpResult(response);
        }).WithName("TotalCuentasActivas");

        group.MapGet("/monto-total-cuentas", async (IEstadisticasLogic logic) =>
        {
            var response = await logic.ObtenerMontoTotalCuentas();
            return Responses.ConvertToHttpResult(response);
        }).WithName("MontoTotalCuentas");

        group.MapGet("/monto-pendiente-cuentas", async (IEstadisticasLogic logic) =>
        {
            var response = await logic.ObtenerMontoTotalCuentasPendientes();
            return Responses.ConvertToHttpResult(response);
        }).WithName("MontoPendienteCuentas");
    }
}

