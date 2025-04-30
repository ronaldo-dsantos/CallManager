using CallManager.Api.DTOs.Chamado;
using CallManager.Application.DTOs.Chamado;
using CallManager.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CallManager.Api.Controllers
{
    [ApiController]
    [Route("api/chamados")]
    public class ChamadosController : MainController
    {
        private readonly IChamadoService _chamadoService;

        public ChamadosController(IChamadoService chamadoService,
                                  INotificador notificador) : base(notificador)
        {
            _chamadoService = chamadoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChamadoReadDto>>> ObterTodos()
        {
            var chamados = await _chamadoService.ObterTodosAsync();
            return CustomResponse(chamados);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ChamadoReadDto>> ObterPorId(Guid id)
        {
            var chamado = await _chamadoService.ObterPorIdAsync(id);

            if (chamado == null) return NotFound();

            return CustomResponse(chamado);
        }

        [HttpPost]
        public async Task<ActionResult> Adicionar(ChamadoCreateDto chamadoCreateDto)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _chamadoService.AdicionarAsync(chamadoCreateDto);

            return CustomResponse(chamadoCreateDto);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Atualizar(Guid id, ChamadoUpdateDto chamadoUpdateDto)
        {
            if (id != chamadoUpdateDto.Id)
            {
                NotificarErro("O ID informado na URL não corresponde ao ID do chamado.");
                return CustomResponse(chamadoUpdateDto);
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _chamadoService.AtualizarAsync(chamadoUpdateDto);

            return CustomResponse(chamadoUpdateDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Remover(Guid id)
        {
            await _chamadoService.RemoverAsync(id);

            return CustomResponse();
        }
    }
}
