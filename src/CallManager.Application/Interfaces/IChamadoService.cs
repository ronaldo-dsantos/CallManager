using CallManager.Application.Models;

namespace CallManager.Application.Interfaces
{
    public interface IChamadoService
    {
        Task<IEnumerable<Chamado>> ObterTodosAsync();
        Task<Chamado> ObterPorIdAsync(int id);
        Task AdicionarAsync(Chamado chamado);
        Task AtualizarAsync(Chamado chamado);
        Task RemoverAsync(int id);
    }
}
