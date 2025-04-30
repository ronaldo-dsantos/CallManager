using CallManager.Api.DTOs.Chamado;
using CallManager.Application.DTOs.Chamado;

namespace CallManager.Application.Interfaces
{
    public interface IChamadoService
    {
        Task<IEnumerable<ChamadoReadDto>> ObterTodosAsync();
        Task<ChamadoReadDto> ObterPorIdAsync(Guid id);
        Task AdicionarAsync(ChamadoCreateDto chamadoCreateDto);
        Task AtualizarAsync(ChamadoUpdateDto chamadoUpdateDto);
        Task RemoverAsync(Guid id);
    }
}
