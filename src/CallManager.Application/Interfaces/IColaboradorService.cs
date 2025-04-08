using CallManager.Application.Models;

namespace CallManager.Application.Interfaces
{
    public interface IColaboradorService
    {
        Task<IEnumerable<Colaborador>> ObterTodosAsync();
        Task<Colaborador> ObterPorMatriculaAsync(int matricula);
        Task AdicionarAsync(Colaborador colaborador);
        Task AtualizarAsync(Colaborador colaborador);
        Task RemoverAsync(int matricula);
    }
}
