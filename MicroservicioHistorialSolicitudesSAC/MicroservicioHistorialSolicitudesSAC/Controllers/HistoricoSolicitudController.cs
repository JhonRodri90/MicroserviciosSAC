using AutoMapper;
using Core.Contracts;
using Core.Request;
using Core.Response;
using MicroservicioHistorialSolicitudesSAC.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioHistorialSolicitudesSAC.Controllers;

public class HistoricoSolicitudController : BaseApiController
{
    private readonly IHistoricoSolicitudService _service;
    private readonly IMapper _mapper;
    private readonly ISolicitudService _solicitudService;

    public HistoricoSolicitudController(IHistoricoSolicitudService service, IMapper mapper, ISolicitudService solicitudService)
    {
        _service = service;
        _mapper = mapper;
        _solicitudService = solicitudService;
    }

    [HttpGet("HistoricoNumero")]
    public async Task<IActionResult> HistoricoNumero(string number)
    {
        IEnumerable<HistoricoSolicitudResponse> resultResponse = await _service.GetByHistoric(number);

        var result = _mapper.Map<IEnumerable<HistoricoSolicitudResDto>>(resultResponse);
        return Ok(result);
    }
}
