using CallManager.Application.DTOs.Colaborador;
using CallManager.Application.Interfaces;
using CallManager.Application.Models;
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
            return CustomResponse(colaboradores);
        }

        [HttpGet("{matricula:int}")]
        public async Task<ActionResult<ColaboradorDto>> ObterPorMatricula(int matricula)
        {
            var colaborador = await _colaboradorService.ObterPorMatriculaAsync(matricula);

            if (colaborador == null) return NotFound();

            return CustomResponse(colaborador);
        }

        [HttpPost]
        public async Task<ActionResult> Adicionar(ColaboradorDto colaboradorDto)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _colaboradorService.AdicionarAsync(colaboradorDto);

            return CustomResponse(colaboradorDto);
        }

        [HttpPut("{matricula:int}")]
        public async Task<ActionResult> Atualizar(int matricula, ColaboradorDto colaboradorDto)
        {
            if (matricula != colaboradorDto.Matricula)
            {
                NotificarErro("A matrícula informada na URL não confere com a matrícula do colaborador.");
                return CustomResponse(colaboradorDto);
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _colaboradorService.AtualizarAsync(colaboradorDto);

            return CustomResponse(colaboradorDto);
        }

        [HttpDelete("{matricula:int}")]
        public async Task<ActionResult> Remover(int matricula)
        {
            await _colaboradorService.RemoverAsync(matricula);

            return CustomResponse();
        }
    }
}
