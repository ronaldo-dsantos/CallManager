using CallManager.Api.DTOs.Colaborador;
using CallManager.Application.Enums;

namespace CallManager.Application.DTOs.Chamado
{
    public class ChamadoReadDto
    {
        public int Id { get; set; }        

        public ColaboradorDto? Colaborador { get; set; }

        public TipoSolicitacao TipoSolicitacao { get; set; }

        public string? Detalhes { get; set; }

        public StatusChamado Status { get; set; } = StatusChamado.Aberto;

        public DateTime DataAbertura { get; set; } = DateTime.UtcNow;

        public DateTime? DataConclusao { get; set; }
    }
}
