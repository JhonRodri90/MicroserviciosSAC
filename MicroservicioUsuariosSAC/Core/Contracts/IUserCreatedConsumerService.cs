using Core.Request;
using MassTransit;

namespace Core.Contracts;

public interface IUserCreatedConsumerService
{
    public Task Consume(ConsumeContext<UsuarioRequest> context);
}
