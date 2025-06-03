namespace Core.Interfaces;

public interface IUnitOfWork:IDisposable
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    ISolicitudRepository SolicitudRepository { get; }
    IUsuarioRepository UsuarioRepository { get; }
    IColaboradorRepository ColaboradorRepository { get; }
    IHistoricoSolicitudRepository HistoricoSolicitudRepository { get; }
    IEstadoSolicitudRepository EstadoSolicitudRepository { get; }
    ITipoSolicitudRepository TipoSolicitudRepository { get; }
}
