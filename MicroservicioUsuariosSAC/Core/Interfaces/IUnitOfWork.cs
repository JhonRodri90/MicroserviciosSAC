namespace Core.Interfaces;

public interface IUnitOfWork:IDisposable
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    IUsuarioRepository UsuarioRepository { get; }
    IColaboradorRepository ColaboradorRepository { get; }
    ILoginRepository LoginRepository { get; }
}
