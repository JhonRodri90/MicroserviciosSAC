using Core.Contracts;
using Core.Request;
using Core.Response;
using MassTransit;

namespace Infrastructure.Consumers
{
    public class CrearSolicitudConsumer : IConsumer<SolicitudEncoladoResponse>
    {
        private readonly ISolicitudService _service;

        public CrearSolicitudConsumer(ISolicitudService service)
        {
            _service = service;
        }

        public async Task Consume(ConsumeContext<SolicitudEncoladoResponse> context)
        {
            var mensaje = context.Message;
            Console.WriteLine($"Mensaje recibido: {mensaje.so_id}");

            var usuario = await _service.Add(mensaje, context.CancellationToken);

            if (usuario != null)
            {
                if (usuario.so_id > 0)
                {
                    Console.WriteLine($"Usuario creado con ID: {usuario.so_id}");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Error al crear la solicitud.");
            }
        }
    }
}
