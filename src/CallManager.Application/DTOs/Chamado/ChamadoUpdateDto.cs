using CallManager.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace CallManager.Application.DTOs.Chamado
{
    public class ChamadoUpdateDto
    {
        [Required(ErrorMessage = "O Id do chamado é obrigatório")]
        [Range(1, 999999, ErrorMessage = "O Id do chamado deve ter de 1 a 6 dígitos")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo detalhes é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo detalhes deve ter no máximo 1000 caracteres")]
        public string? Detalhes { get; set; }

        public StatusChamado Status { get; set; } 
    }
}
