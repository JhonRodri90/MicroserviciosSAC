using Core.Request;
using Core.Response;

namespace Core.Contracts;

public interface ISolicitudService
{
    #region CRUD
    public Task<SolicitudResponse> Add(SolicitudEncoladoResponse request, CancellationToken cancellationToken);
    public Task<bool> Delete(int id, CancellationToken cancellationToken);
    public Task<SolicitudResponse> Update(int id, SolicitudRequest request, CancellationToken cancellationToken);
    public Task<SolicitudResponse> GetById(int id);
    #endregion
}
