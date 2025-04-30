using CallManager.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace CallManager.Application.DTOs.Chamado
{
    public class ChamadoUpdateDto
    {
        [Required(ErrorMessage = "O Id do chamado é obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O status do chamado é obrigatório")]
        [EnumDataType(typeof(StatusChamado), ErrorMessage = "O status informado é inválido")]
        public StatusChamado Status { get; set; }

        [Required(ErrorMessage = "O campo Detalhes da Tratativa é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo Detalhes da Tratativa deve ter no máximo 1000 caracteres")]
        public string DetalhesTratativa { get; set; } = string.Empty;
    }
}
