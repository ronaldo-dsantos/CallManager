using CallManager.Application.DTOs.Chamado;

namespace CallManager.Application.Interfaces
{
    public interface IChamadoService
    {
        Task<IEnumerable<ChamadoReadDto>> ObterTodosAsync();
        Task<ChamadoReadDto> ObterPorIdAsync(int id);
        Task AdicionarAsync(ChamadoCreateDto chamadoCreateDto);
        Task AtualizarAsync(ChamadoUpdateDto chamadoUpdateDto);
        Task RemoverAsync(int id);
    }
}
