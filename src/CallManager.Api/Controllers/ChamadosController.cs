using CallManager.Api.DTOs.Chamado;
using CallManager.Application.DTOs.Chamado;
using CallManager.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CallManager.Api.Controllers
{
    [ApiController]
    [Route("api/chamados")]
    public class ChamadosController : Controller
    {
        private readonly IChamadoService _chamadoService;

        public ChamadosController(IChamadoService chamadoService)
        {
            _chamadoService = chamadoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChamadoReadDto>>> ObterTodos()
        {
            var chamados = await _chamadoService.ObterTodosAsync();
            return Ok(chamados);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ChamadoReadDto>> ObterPorId(int id)
        {
            var chamado = await _chamadoService.ObterPorIdAsync(id);
            if (chamado == null) return NotFound();
            return Ok(chamado);
        }

        [HttpPost]
        public async Task<ActionResult> Adicionar([FromBody] ChamadoDto chamadoDto)
        {
            await _chamadoService.AdicionarAsync(chamadoDto);
            return CreatedAtAction(nameof(ObterPorId), new { id = chamadoDto.Id }, chamadoDto);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Atualizar(int id, [FromBody] ChamadoDto chamadoDto)
        {
            if (id != chamadoDto.Id)
                return BadRequest("O ID informado não confere com o chamado.");

            await _chamadoService.AtualizarAsync(chamadoDto);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Remover(int id)
        {
            await _chamadoService.RemoverAsync(id);
            return NoContent();
        }
    }
}
