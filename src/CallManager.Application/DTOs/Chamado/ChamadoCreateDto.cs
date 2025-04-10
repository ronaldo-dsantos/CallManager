using CallManager.Application.Enums;

namespace CallManager.Api.DTOs.Chamado
{
    public class ChamadoCreateDto
    {        
        public int MatriculaColaborador { get; set; }
        
        public TipoSolicitacao TipoSolicitacao { get; set; }
        
        public string? Detalhes { get; set; }
    }
}
