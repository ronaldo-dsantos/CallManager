using CallManager.Application.Interfaces;
using CallManager.Application.Models;
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
        public async Task<ActionResult<IEnumerable<Chamado>>> GetTodos()
        {
            var chamados = await _chamadoService.ObterTodosAsync();
            return Ok(chamados);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Chamado>> GetPorId(int id)
        {
            var chamado = await _chamadoService.ObterPorIdAsync(id);
            if (chamado == null) return NotFound();
            return Ok(chamado);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Chamado chamado)
        {
            await _chamadoService.AdicionarAsync(chamado);
            return CreatedAtAction(nameof(GetPorId), new { id = chamado.Id }, chamado);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Chamado chamado)
        {
            if (id != chamado.Id)
                return BadRequest("O ID informado não confere com o chamado.");

            await _chamadoService.AtualizarAsync(chamado);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _chamadoService.RemoverAsync(id);
            return NoContent();
        }
    }
}
