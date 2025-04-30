using CallManager.Application.Models;

namespace CallManager.Application.Interfaces
{
    public interface IChamadoRepository : IRepository<Chamado>
    {
        Task<IEnumerable<Chamado>> ObterChamadosComColaboradorAsync();

        Task<Chamado?> ObterChamadoComColaboradorPorIdAsync(Guid id);
    }
}
