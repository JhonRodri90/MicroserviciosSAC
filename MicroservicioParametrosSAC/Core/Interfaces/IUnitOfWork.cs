namespace Core.Interfaces;

public interface IUnitOfWork:IDisposable
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    IEstadoSolicitudRepository EstadoSolicitudRepository { get; }
    ITipoSolicitudRepository TipoSolicitudRepository { get; }
}
