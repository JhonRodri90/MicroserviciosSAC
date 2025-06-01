using AutoMapper;
using Core.Contracts;
using Core.Request;
using Core.Response;
using MicroservicioUsuariosSAC.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioUsuariosSAC.Controllers
{
    public class UsuariosController : BaseApiController
    {
        private readonly IUsuarioService _service;
        private readonly IMapper _mapper;

        public UsuariosController(IUsuarioService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<UsuarioResponse> resultResponse = await _service.GetAll();

            var result = _mapper.Map<IEnumerable<UsuarioResDto>>(resultResponse);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Upsert(UsuarioRequestDto UsuarioReq, CancellationToken cancellationToken)
        {
            var usuReq = _mapper.Map<UsuarioRequest>(UsuarioReq);
            if (usuReq.us_id == 0)
            {

                var usuario = await _service.Add(usuReq, cancellationToken);
                var result = _mapper.Map<UsuarioResDto>(usuario);
                return Ok(result);

            }
            else
            {
                var usuario = await _service.Update(usuReq.us_id, usuReq, cancellationToken);
                var result = _mapper.Map<UsuarioResDto>(usuario);
                return Ok(result);
            }
        }
    }
}
