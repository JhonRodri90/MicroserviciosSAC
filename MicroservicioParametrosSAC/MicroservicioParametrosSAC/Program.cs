using AutoMapper;
using Infrastructure.Data;
using MicroservicioParametrosSAC.Profiles;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//builder.Services.AddScoped<IAppConfig, AppConfig>();


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

app.UseCors(corsPolicyName);
app.UseCors(corsPolicyNameEsp);

app.UseAuthorization();

app.MapControllers();

// Endpoint raíz para validar
app.MapGet("/", () => "API funcionando");

app.Run();
