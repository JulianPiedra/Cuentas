using ApiCuentasInjection;
using BussinessLogic;
using CuentasApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Models;


public static class CuentaEndpoints
{
    public static void MapCuentaEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/cuentas").WithTags(nameof(CuentaDAO));

        group.MapPost("/agregar", async (CuentaDAO cuenta, ICuentaLogic cuentaLogic) =>
        {
            if (cuenta == null)
                return Results.BadRequest(new { codigo = 400, mensaje = "Cuenta no puede ser nula." });

            var response = await cuentaLogic.AgregarCuenta(cuenta);
            return Responses.ConvertToHttpResult(response);
        })
        .WithName("AgregarCuenta");

        group.MapGet("/obtener", async (ICuentaLogic cuentaLogic) =>
        {
            var response = await cuentaLogic.ObtenerCuentas();
            return Responses.ConvertToHttpResult(response);
        })
        .WithName("ObtenerCuentas");

        group.MapGet("/{id:int}/pagos", async (int id, ICuentaLogic cuentaLogic) =>
        {
            if (id <= 0)
                return Results.BadRequest(new { codigo = 400, mensaje = "ID de cuenta inválido." });

            var response = await cuentaLogic.ObtenerCuentasConPagos(id);
            return Responses.ConvertToHttpResult(response);
        })
        .WithName("ObtenerCuentasConPagos");

        group.MapPatch("/{idCuenta:int}/pago/{idPago:int}/estado", async (int idCuenta, int idPago, ICuentaLogic cuentaLogic) =>
        {
            if (idCuenta <= 0 || idPago <= 0)
                return Results.BadRequest(new { codigo = 400, mensaje = "ID de cuenta o pago inválido." });

            var response = await cuentaLogic.ActualizarEstadoPago(idCuenta, idPago);
            return Responses.ConvertToHttpResult(response);
        })
        .WithName("ActualizarEstadoPago");

        group.MapPost("/{idCuenta:int}/multar", async (int idCuenta, DateOnly fechaPago, ICuentaLogic cuentaLogic) =>
        {
            if (idCuenta <= 0)
                return Results.BadRequest(new { codigo = 400, mensaje = "ID de cuenta inválido." });

            var response = await cuentaLogic.MultarCuenta(idCuenta, fechaPago);
            return Responses.ConvertToHttpResult(response);
        })
        .WithName("MultarCuenta");

        group.MapPut("/editar", async (CuentaDAO cuenta, ICuentaLogic cuentaLogic) =>
        {
            if (cuenta == null || cuenta.Cuenta <= 0)
                return Results.BadRequest(new { codigo = 400, mensaje = "Cuenta inválida para editar." });

            var response = await cuentaLogic.EditarCuenta(cuenta);
            return Responses.ConvertToHttpResult(response);
        })
        .WithName("EditarCuenta");
    }


}

