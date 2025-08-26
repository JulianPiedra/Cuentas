using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;

public class ApiKeyAuthenticationSchemeHandler : AuthenticationHandler<ApiKeyAuthenticationSchemeOptions>
{
    private const string ApiKeyHeaderName = "X_API_KEY";

    public ApiKeyAuthenticationSchemeHandler(
        IOptionsMonitor<ApiKeyAuthenticationSchemeOptions> options,
        ILoggerFactory logger,
        UrlEncoder encoder,
        ISystemClock clock
    ) : base(options, logger, encoder, clock)
    {
    }

    protected override Task HandleChallengeAsync(AuthenticationProperties properties)
    {
        Response.StatusCode = 401; // Unauthorized
        Response.ContentType = "application/json";

        // Si AuthenticateResult.Fail(...) tiene mensaje, úsalo
        string mensaje = Context.Items["AuthFailureMessage"] as string ?? "API Key inválida o no proporcionada";

        return Response.WriteAsync($"{{\"message\":\"{mensaje}\"}}");
    }

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Headers.TryGetValue(ApiKeyHeaderName, out var extractedApiKey))
        {
            // Guardamos el mensaje para HandleChallengeAsync
            Context.Items["AuthFailureMessage"] = "API Key no proporcionada";
            return Task.FromResult(AuthenticateResult.Fail("API Key no proporcionada"));
        }

        if (!Options.ApiKey.Equals(extractedApiKey))
        {
            Context.Items["AuthFailureMessage"] = "API Key inválida";
            return Task.FromResult(AuthenticateResult.Fail("API Key inválida"));
        }

        var claims = new[]
        {
        new Claim(ClaimTypes.NameIdentifier, "API"),
        new Claim(ClaimTypes.Name, "API Key User")
    };

        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, Scheme.Name);

        return Task.FromResult(AuthenticateResult.Success(ticket));
    }


}
