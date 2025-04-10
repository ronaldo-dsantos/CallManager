using CallManager.Api.DTOs.Colaborador;
using CallManager.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CallManager.Api.Controllers
{
    [ApiController]
    [Route("api/colaboradores")]
    public class ColaboradoresController : MainController  
    {
        private readonly IColaboradorService _colaboradorService;

        public ColaboradoresController(IColaboradorService colaboradorService, 
                                       INotificador notificador) : base(notificador)
        {
            _colaboradorService = colaboradorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ColaboradorDto>>> ObterTodos()
        {
            var colaboradores = await _colaboradorService.ObterTodosAsync();
            return Ok(colaboradores);
        }

        [HttpGet("{matricula:int}")]
        public async Task<ActionResult<ColaboradorDto>> ObterPorMatricula(int matricula)
        {
            var colaborador = await _colaboradorService.ObterPorMatriculaAsync(matricula);
            if (colaborador == null) return NotFound();
            return Ok(colaborador);
        }

        [HttpPost]
        public async Task<ActionResult> Adicionar([FromBody] ColaboradorDto colaboradorDto)
        {
            await _colaboradorService.AdicionarAsync(colaboradorDto);
            return CreatedAtAction(nameof(ObterPorMatricula), new { matricula = colaboradorDto.Matricula }, colaboradorDto);
        }

        [HttpPut("{matricula:int}")]
        public async Task<ActionResult> Atualizar(int matricula, [FromBody] ColaboradorDto colaboradorDto)
        {
            if (matricula != colaboradorDto.Matricula)
                return BadRequest("Matrícula do colaborador não confere com a da rota.");

            await _colaboradorService.AtualizarAsync(colaboradorDto);
            return NoContent();
        }

        [HttpDelete("{matricula:int}")]
        public async Task<ActionResult> Remover(int matricula)
        {
            await _colaboradorService.RemoverAsync(matricula);
            return NoContent();
        }
    }
}
