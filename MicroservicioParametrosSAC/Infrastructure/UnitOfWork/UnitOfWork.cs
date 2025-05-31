using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork:IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public IEstadoSolicitudRepository EstadoSolicitudRepository { get; private set; }
    public ITipoSolicitudRepository TipoSolicitudRepository { get; private set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        EstadoSolicitudRepository = new EstadoSolicitudRepository(_context);
        TipoSolicitudRepository = new TipoSolicitudRepository(_context);
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
