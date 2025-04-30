using CallManager.Application.Enums;

namespace CallManager.Application.Models
{
    public class Chamado : Entity
    {
        public int MatriculaColaborador { get; set; }
        public Colaborador? Colaborador { get; set; }

        public TipoSolicitacao TipoSolicitacao { get; set; }
        public StatusChamado Status { get; set; } = StatusChamado.Aberto;

        public string? DetalhesSolicitacao { get; set; }
        public string? DetalhesTratativa { get; set; }

        public string? AbertoPor { get; set; }
        public DateTime DataAbertura { get; set; } = DateTime.UtcNow;

        public string? ConcluidoPor { get; set; }
        public DateTime? DataConclusao { get; set; }
    }
}
