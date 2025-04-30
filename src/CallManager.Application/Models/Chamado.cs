using CallManager.Application.Enums;

namespace CallManager.Application.Models
{
    public class Chamado : Entity
    {
        public Guid ColaboradorId { get; set; }
        public Colaborador? Colaborador { get; set; }

        public TipoSolicitacao TipoSolicitacao { get; set; }
        public StatusChamado Status { get; set; } = StatusChamado.Aberto;

        public string DetalhesSolicitacao { get; set; } = string.Empty;
        public string? DetalhesTratativa { get; set; }

        public string AbertoPor { get; set; } = string.Empty;
        public DateTime DataAbertura { get; set; } = DateTime.UtcNow;

        public string? ConcluidoPor { get; set; }
        public DateTime? DataConclusao { get; set; }
    }
}
