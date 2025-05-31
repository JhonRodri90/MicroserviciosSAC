using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork:IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public IUsuarioRepository UsuarioRepository { get; private set; }
    public IColaboradorRepository ColaboradorRepository { get; private set; }
    public ILoginRepository LoginRepository { get; private set; }


    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        UsuarioRepository = new UsuarioRepository(_context);
        ColaboradorRepository = new ColaboradorRepository(_context);
        LoginRepository = new LoginRepository(_context);
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }
}
