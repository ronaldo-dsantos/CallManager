using CallManager.Api.DTOs.Chamado;
using CallManager.Application.DTOs.Chamado;

namespace CallManager.Application.Interfaces
{
    public interface IChamadoService
    {
        Task<IEnumerable<ChamadoReadDto>> ObterTodosAsync();
        Task<ChamadoReadDto> ObterPorIdAsync(int id);
        Task AdicionarAsync(ChamadoDto chamadoDto);
        Task AtualizarAsync(ChamadoDto chamadoDto);
        Task RemoverAsync(int id);
    }
}
