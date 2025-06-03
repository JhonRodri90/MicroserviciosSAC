using AutoMapper;
using Core.Contracts;
using Core.Interfaces;
using Infrastructure.Consumers;
using Infrastructure.Data;
using Infrastructure.Services;
using Infrastructure.UnitOfWork;
using MassTransit;
using MicroservicioHistorialSolicitudesSAC.Profiles;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<CrearSolicitudConsumer>();
    x.AddConsumer<CrearUsuarioConsumer>();
    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("rabbitmq", "/", h =>
        {
            h.Username("guest");
            h.Password("guest");
        });
        cfg.ReceiveEndpoint("crear-solicitud-queue", e =>
        {
            e.ConfigureConsumer<CrearSolicitudConsumer>(context);
        });

        cfg.ReceiveEndpoint("crear-usuarioHistorico-queue", e =>
        {
            e.ConfigureConsumer<CrearUsuarioConsumer>(context);
        });
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Logging.AddConsole();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(80);
});

builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
{
    var connetionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString));
});

var corsPolicyName = "AllowAll";
var corsPolicyNameEsp = "AllowSecureOriginsWithCredentials";

builder.Services.AddCors(options =>
{
    options.AddPolicy(corsPolicyName, policy =>
    {
        policy.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
    });

    options.AddPolicy(corsPolicyNameEsp, policy =>
    {
        policy.WithOrigins("https://main.d3qlabcxqrorrx.amplifyapp.com/")  // Especifica los orígenes HTTPS permitidos
              .AllowAnyMethod()  // Permite cualquier método HTTP
              .AllowAnyHeader()  // Permite cualquier cabecera
              .AllowCredentials();  // Permite el envío de credenciales (cookies, tokens, etc.)
    });
});

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfiles());
});
IMapper mapper = mapperConfig.CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ISolicitudService, SolicitudService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IColaboradorService, ColaboradorService>();
builder.Services.AddScoped<IHistoricoSolicitudService, HistoricoSolicitudService>();



var app = builder.Build();

// **Aplicar migraciones automáticamente al iniciar la aplicación**
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate(); // Aplica las migraciones pendientes si es necesario
}

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
});


app.UseCors(corsPolicyName);
app.UseCors(corsPolicyNameEsp);

app.Logger.LogInformation("Aplicación ASP.NET Core está lista para arrancar");

app.UseAuthorization();

app.MapControllers();

// Endpoint raíz para validar
app.MapGet("/", () => "API funcionando");

app.Run();
