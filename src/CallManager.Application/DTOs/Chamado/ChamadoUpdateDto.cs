using CallManager.Application.Enums;

namespace CallManager.Application.DTOs.Chamado
{
    public class ChamadoUpdateDto
    {
        public int Id { get; set; }

        public int MatriculaColaborador { get; set; }

        public TipoSolicitacao TipoSolicitacao { get; set; }

        public string? Detalhes { get; set; }
    }
}
