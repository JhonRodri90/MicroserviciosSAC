using Amazon;
using Amazon.S3;
using AutoMapper;
using Core.Contracts;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Services;
using Infrastructure.UnitOfWork;
using MassTransit;
using MicroservicioSolicitudSAC.Profiles;
using Microsoft.EntityFrameworkCore;
using static Infrastructure.Services.SolicitudService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMassTransit(x =>
{
    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("rabbitmq", "/", h =>
        {
            h.Username("guest");
            h.Password("guest");
        });
    });
});

builder.Services.AddControllers();
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
builder.Services.AddScoped<INumeroSolicitudService, NumeroSolicitudService>();
builder.Services.AddScoped<ISolicitudService, SolicitudService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ICantidadSolicitudService, CantidadSolicitudService>();
builder.Services.AddScoped<IColaboradorService, ColaboradorService>();

//builder.Services.AddSingleton<IAmazonS3>(sp => new AmazonS3Client(
//    builder.Configuration["AWSS3BUCKET:AccessKey"],
//    builder.Configuration["AWSS3BUCKET:SecretKey"],
//    RegionEndpoint.GetBySystemName(builder.Configuration["AWSS3BUCKET:Region"])
//));

var app = builder.Build();

// **Aplicar migraciones automáticamente al iniciar la aplicación**
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate(); // Aplica las migraciones pendientes si es necesario
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
});

app.Logger.LogInformation("Aplicación ASP.NET Core está lista para arrancar");

app.UseCors(corsPolicyName);
app.UseCors(corsPolicyNameEsp);

app.UseAuthorization();

app.MapControllers();

// Endpoint raíz para validar
app.MapGet("/", () => "API funcionando");

app.Run();

app.Logger.LogInformation("Esto nunca debería verse si todo va bien");