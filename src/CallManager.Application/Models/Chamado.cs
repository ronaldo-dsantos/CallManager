using CallManager.Application.Enums;

namespace CallManager.Application.Models
{
    public class Chamado
    {
        public int Id { get; set; }

        public int MatriculaColaborador { get; set; }
        public Colaborador Colaborador { get; set; } = null!;

        public TipoChamado Tipo { get; set; }
        public StatusChamado Status { get; set; } = StatusChamado.Aberto;

        public string Descricao { get; set; } = string.Empty;
        public string? Tratativa { get; set; }

        public string AbertoPor { get; set; } = string.Empty;
        public DateTime DataAbertura { get; set; } = DateTime.UtcNow;

        public string? ConcluidoPor { get; set; }
        public DateTime? DataConclusao { get; set; }
    }
}
