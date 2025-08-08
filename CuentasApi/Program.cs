using ApiCuentasInjection;
using BussinessLogic;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//CORS Configuration 
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Database context
builder.Services.AddDbContext<BdContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "X_API_KEY",
        Type = SecuritySchemeType.ApiKey,
        Description = "Unauthorized. API key is missing or invalid."
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "ApiKey",
                }
            },
            Array.Empty<string>()
        }
    });
});

// Authentication & Authorization
builder.Services.AddAuthorization();
builder.Services.AddAuthentication("ApiKey")
    .AddScheme<ApiKeyAuthenticationSchemeOptions, ApiKeyAuthenticationSchemeHandler>(
        "ApiKey",
        opts => opts.ApiKey = builder.Configuration.GetValue<string>("ApiKey") ?? "No key provided"
    );


// Dependency Injection for business logic
builder.Services.AddScoped<ICuentaLogic, CuentaLogic>();
builder.Services.AddScoped<IClienteLogic, ClientesLogic>();
builder.Services.AddScoped<IEstadisticasLogic, EstadisticasLogic>();



var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors("AllowAll");
app.MapControllers();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapCuentaEndpoints();
app.MapClienteEndpoints();
app.MapEstadisticasEndpoints();

app.Run();
