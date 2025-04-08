using CallManager.Application.Interfaces;
using CallManager.Application.Models;

namespace CallManager.Application.Services
{
    public class ColaboradorService : IColaboradorService
    {
        private readonly IColaboradorRepository _colaboradorRepository;

        public ColaboradorService(IColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }

        public async Task<IEnumerable<Colaborador>> ObterTodosAsync()
            => await _colaboradorRepository.ObterTodosAsync();

        public async Task<Colaborador> ObterPorMatriculaAsync(int matricula)
            => await _colaboradorRepository.ObterPorIdAsync(matricula);

        public async Task AdicionarAsync(Colaborador colaborador)
            => await _colaboradorRepository.AdicionarAsync(colaborador);

        public async Task AtualizarAsync(Colaborador colaborador)
            => await _colaboradorRepository.AtualizarAsync(colaborador);

        public async Task RemoverAsync(int matricula)
            => await _colaboradorRepository.RemoverAsync(matricula);
    }
}
