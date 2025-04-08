using CallManager.Application.Interfaces;
using CallManager.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace CallManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColaboradoresController : ControllerBase
    {
        private readonly IColaboradorService _colaboradorService;

        public ColaboradoresController(IColaboradorService colaboradorService)
        {
            _colaboradorService = colaboradorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Colaborador>>> GetTodos()
        {
            var colaboradores = await _colaboradorService.ObterTodosAsync();
            return Ok(colaboradores);
        }

        [HttpGet("{matricula:int}")]
        public async Task<ActionResult<Colaborador>> GetPorMatricula(int matricula)
        {
            var colaborador = await _colaboradorService.ObterPorMatriculaAsync(matricula);
            if (colaborador == null) return NotFound();
            return Ok(colaborador);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Colaborador colaborador)
        {
            await _colaboradorService.AdicionarAsync(colaborador);
            return CreatedAtAction(nameof(GetPorMatricula), new { matricula = colaborador.Matricula }, colaborador);
        }

        [HttpPut("{matricula:int}")]
        public async Task<ActionResult> Put(int matricula, [FromBody] Colaborador colaborador)
        {
            if (matricula != colaborador.Matricula)
                return BadRequest("Matrícula do colaborador não confere com a da rota.");

            await _colaboradorService.AtualizarAsync(colaborador);
            return NoContent();
        }

        [HttpDelete("{matricula:int}")]
        public async Task<ActionResult> Delete(int matricula)
        {
            await _colaboradorService.RemoverAsync(matricula);
            return NoContent();
        }
    }
}
