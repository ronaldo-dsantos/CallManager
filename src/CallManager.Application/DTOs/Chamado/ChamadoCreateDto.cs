using CallManager.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace CallManager.Application.DTOs.Chamado
{
    public class ChamadoCreateDto
    {
        [Required(ErrorMessage = "A matrícula do colaborador é obrigatória")]
        [Range(1, 999999, ErrorMessage = "A matrícula deve ter de 1 a 6 dígitos")]
        public int MatriculaColaborador { get; set; }

        [Required(ErrorMessage = "O tipo do chamado é obrigatório")]
        [EnumDataType(typeof(TipoChamado), ErrorMessage = "O tipo do chamado é inválido")]
        public TipoChamado Tipo { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [StringLength(1000, ErrorMessage = "A descrição deve ter no máximo 1000 caracteres")]
        public string Descricao { get; set; } = string.Empty;
    }
}
