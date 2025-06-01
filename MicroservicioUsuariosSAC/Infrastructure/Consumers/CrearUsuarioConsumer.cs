using System.Threading;
using Core.Contracts;
using Core.Request;
using MassTransit;

namespace Infrastructure.Consumers;

public class CrearUsuarioConsumer : IConsumer<UsuarioRequest>
{
    private readonly IUsuarioService _service;

    public CrearUsuarioConsumer(IUsuarioService service)
    {
        _service = service;
    }

    public async Task Consume(ConsumeContext<UsuarioRequest> context)
    {
        var mensaje = context.Message;
        Console.WriteLine($"Mensaje recibido: {mensaje.us_id} - {mensaje.us_correo}");

        var usuario = await _service.Add(mensaje, context.CancellationToken);

        if (usuario != null)
        {
            if(usuario.us_id > 0)
            {
                Console.WriteLine($"Usuario creado con ID: {usuario.us_id}");
                return;
            }
        }
        else
        {
            Console.WriteLine("Error al crear el usuario.");
        }
    }
}


