using CallManager.Application.Interfaces;
using CallManager.Application.Models;

namespace CallManager.Application.Services
{
    public class ChamadoService : IChamadoService
    {
        private readonly IChamadoRepository _chamadoRepository;

        public ChamadoService(IChamadoRepository chamadoRepository)
        {
            _chamadoRepository = chamadoRepository;
        }

        public async Task<IEnumerable<Chamado>> ObterTodosAsync()
            => await _chamadoRepository.ObterTodosAsync();

        public async Task<Chamado> ObterPorIdAsync(int id)
            => await _chamadoRepository.ObterPorIdAsync(id);

        public async Task AdicionarAsync(Chamado chamado)
            => await _chamadoRepository.AdicionarAsync(chamado);

        public async Task AtualizarAsync(Chamado chamado)
            => await _chamadoRepository.AtualizarAsync(chamado);

        public async Task RemoverAsync(int id)
            => await _chamadoRepository.RemoverAsync(id);
    }
}
