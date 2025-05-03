using CallManager.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace CallManager.Application.DTOs.Chamado
{
    public class ChamadoUpdateDto
    {
        [Required(ErrorMessage = "O ID do chamado é obrigatório")]
        [Range(1, 999999, ErrorMessage = "O ID do chamado deve ser um número de até 6 dígitos")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O status do chamado é obrigatório")]
        [EnumDataType(typeof(StatusChamado), ErrorMessage = "O status informado é inválido")]
        public StatusChamado Status { get; set; }

        [Required(ErrorMessage = "O campo tratativa é obrigatório")]
        [StringLength(1000, MinimumLength = 5, ErrorMessage = "A tratativa deve ter entre 5 e 1000 caracteres")]
        public string Tratativa { get; set; } = string.Empty;
    }
}
