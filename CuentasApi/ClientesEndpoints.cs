using ApiCuentasInjection;
using BussinessLogic;
using CuentasApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Models;


public static class ClienteEndpoints
{
    public static void MapClienteEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/clientes").WithTags(nameof(ClienteDAO));

        group.MapPost("/agregar", async (ClienteDAO cliente, IClienteLogic clienteLogic) =>
        {
            if (cliente == null || string.IsNullOrWhiteSpace(cliente.IdCliente))
                return Results.BadRequest(new { codigo = 400, mensaje = "Datos del cliente inválidos." });

            var response = await clienteLogic.AgregarCliente(cliente);
            return Responses.ConvertToHttpResult(response);
        })
        .WithName("AgregarCliente");

        group.MapPost("/{idCliente}/multimedia", async (string idCliente, Dictionary<string, byte[]> archivos, IClienteLogic clienteLogic) =>
        {
            if (string.IsNullOrWhiteSpace(idCliente))
                return Results.BadRequest(new { codigo = 400, mensaje = "ID de cliente inválido." });

            var response = await clienteLogic.AgregarMultimedia(idCliente, archivos);
            return Responses.ConvertToHttpResult(response);
        })
        .WithName("AgregarMultimedia");

        group.MapGet("/obtener", async (IClienteLogic clienteLogic) =>
        {
            var response = await clienteLogic.ObtenerClientes();
            return Responses.ConvertToHttpResult(response);
        })
        .WithName("ObtenerClientes");

        group.MapGet("/{idCliente}", async (string idCliente, IClienteLogic clienteLogic) =>
        {
            if (string.IsNullOrWhiteSpace(idCliente))
                return Results.BadRequest(new { codigo = 400, mensaje = "ID de cliente inválido." });

            var response = await clienteLogic.ObtenerClienteConMultimedia(idCliente);
            return Responses.ConvertToHttpResult(response);
        })
        .WithName("ObtenerClienteConMultimedia");

        group.MapPut("/editar", async (ClienteDAO cliente, IClienteLogic clienteLogic) =>
        {
            if (cliente == null || string.IsNullOrWhiteSpace(cliente.IdCliente))
                return Results.BadRequest(new { codigo = 400, mensaje = "Datos del cliente inválidos." });

            var response = await clienteLogic.EditarCliente(cliente);
            return Responses.ConvertToHttpResult(response);
        })
        .WithName("EditarCliente");
    }
}

