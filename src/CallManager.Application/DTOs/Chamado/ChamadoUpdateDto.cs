using CallManager.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace CallManager.Application.DTOs.Chamado
{
    public class ChamadoUpdateDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(100000, 999999)]
        public int MatriculaColaborador { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public TipoSolicitacao TipoSolicitacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(1000)]
        public string? Detalhes { get; set; }
    }
}
