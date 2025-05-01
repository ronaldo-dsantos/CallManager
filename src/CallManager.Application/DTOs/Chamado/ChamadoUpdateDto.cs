using CallManager.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace CallManager.Application.DTOs.Chamado
{
    public class ChamadoUpdateDto
    {
        [Required(ErrorMessage = "O Id do chamado é obrigatório")]
        public Guid Id { get; set; }

        [EnumDataType(typeof(StatusChamado), ErrorMessage = "O status do chamado é inválido")]
        public StatusChamado Status { get; set; }

        [Required(ErrorMessage = "O campo tratativa é obrigatório")]
        [StringLength(1000, ErrorMessage = "A tratativa deve ter no máximo 1000 caracteres")]
        public string? Tratativa { get; set; }
    }
}
