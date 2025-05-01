using CallManager.Application.DTOs.Colaborador;

namespace CallManager.Application.Interfaces
{
    public interface IColaboradorService
    {
        Task<IEnumerable<ColaboradorDto>> ObterTodosAsync();
        Task<ColaboradorDto> ObterPorMatriculaAsync(int matricula);
        Task AdicionarAsync(ColaboradorDto colaboradorDto);
        Task AtualizarAsync(ColaboradorDto colaboradorDto);
        Task RemoverAsync(int matricula);
    }
}
