using AutoMapper;
using Core.Contracts;
using Core.Entities;
using Core.Interfaces;
using Core.Request;
using Core.Response;
using MassTransit;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Services;

public class SolicitudService : ISolicitudService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IPublishEndpoint _publishEndpoint;
    string relationsUsers = "Estados_Solicitudes,Tipos_Solicitudes,SolicitudApelacion,Usuarios,Usuarios.Tipo_Identificacion,Usuarios.Tipos_Usuarios,Colaboradores";


    public SolicitudService(IUnitOfWork unitOfWork, IMapper mapper,
                                IUsuarioService usuarioService, IConfiguration configuration,
                                IColaboradorService colaboradorService, IPublishEndpoint publishEndpoint)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _publishEndpoint = publishEndpoint;
    }



    public async Task<SolicitudResponse> Add(SolicitudEncoladoResponse request, CancellationToken cancellationToken)
    {
        Solicitudes entity = _mapper.Map<Solicitudes>(request);

        await _unitOfWork.SolicitudRepository.Create(entity, cancellationToken);
        int result = await _unitOfWork.SaveChangesAsync(cancellationToken);

        if (result > 0)
        {
            var entidadNueva = await GetById(entity.so_id);

            var entityResponse = _mapper.Map<SolicitudResponse>(entidadNueva);

            await GrabarHistorico(entityResponse, "Creacion", cancellationToken);

            return entityResponse;
        }
        else
        {
            return null;
        }
    }

    public async Task<bool> Delete(int id, CancellationToken cancellationToken)
    {
        await _unitOfWork.SolicitudRepository.Delete(id, cancellationToken);
        int result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        return result > 0;
    }

    public async Task<SolicitudResponse> GetById(int id)
    {
        Solicitudes? entity = await _unitOfWork.SolicitudRepository.ReadById(x => x.so_id.Equals(id),
                                                                            includeProperties: relationsUsers);
        SolicitudResponse response = _mapper.Map<SolicitudResponse>(entity);
        return response;
    }

    public async Task<SolicitudResponse> Update(int id, SolicitudRequest request, CancellationToken cancellationToken)
    {

        SolicitudResponse entityNew = await GetById(id);

        Solicitudes entity = _mapper.Map<Solicitudes>(entityNew);
        

        await _unitOfWork.SolicitudRepository.Update(id, entity, cancellationToken);
        int result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result > 0)
        {
            var entidadNueva = await GetById(entity.so_id);

            var entityResponse = _mapper.Map<SolicitudResponse>(entidadNueva);

            await GrabarHistorico(entityResponse, "Actualizacion", cancellationToken);

            return entityResponse;
        }
        else
        {
            return null;
        }
    }
    private async Task<int> GrabarHistorico(SolicitudResponse entityResponse, string accion, CancellationToken cancellationToken)
    {
        var historico = new HistoricoSolicitudRequest
        {
            hs_so_id = entityResponse.so_id,
            hs_es_id = entityResponse.so_es_id,
            hs_col_id = entityResponse.so_col_id,
            hs_detalle = accion,
            hs_fecha = DateTime.Now
        };

        var his = new HistoricoSolicitudService(_unitOfWork, _mapper);
        var response = await his.Add(historico, cancellationToken);

        if (response != null)
            return 0;
        else
            return 1;


    }
}