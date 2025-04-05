using CallManager.Application.Enums;

namespace CallManager.Application.Models
{
    public class Chamado
    {
        public int Id { get; set; }

        public int MatriculaColaborador { get; set; }   

        public TipoSolicitacao TipoSolicitacao { get; set; }

        public string? Detalhes { get; set; }

        public StatusChamado Status { get; set; } = StatusChamado.Aberto;

        public DateTime DataAbertura { get; set; } = DateTime.UtcNow;

        public DateTime? DataConclusao { get; set; }

        // Relacionamento com o colaborador
        public Colaborador? Colaborador { get; set; } 
    }
}
