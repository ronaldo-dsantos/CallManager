using CallManager.Api.DTOs.Colaborador;
using CallManager.Application.Enums;

namespace CallManager.Application.DTOs.Chamado
{
    public class ChamadoReadDto
    {
        public Guid Id { get; set; }  
        public ColaboradorDto? Colaborador { get; set; }

        public TipoSolicitacao TipoSolicitacao { get; set; }
        public StatusChamado Status { get; set; } = StatusChamado.Aberto;

        public string DetalhesSolicitacao { get; set; } = string.Empty;
        public string DetalhesTratativa { get; set; } = string.Empty;

        public string AbertoPor { get; set; } = string.Empty;
        public DateTime DataAbertura { get; set; } = DateTime.UtcNow;

        public string? ConcluidoPor { get; set; }
        public DateTime? DataConclusao { get; set; }
    }
}
