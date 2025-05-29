var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Logging.AddConsole();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(80);
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
});

app.Logger.LogInformation("Aplicación ASP.NET Core está lista para arrancar");

app.UseAuthorization();

app.MapControllers();

// Endpoint raíz para validar
app.MapGet("/", () => "API funcionando");

app.Run();

app.Logger.LogInformation("Esto nunca debería verse si todo va bien");