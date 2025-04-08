using CallManager.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace CallManager.Api.DTOs.Chamado
{
    public class ChamadoCreateDto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int MatriculaColaborador { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public TipoSolicitacao TipoSolicitacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? Detalhes { get; set; }
    }
}
