using CallManager.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace CallManager.Application.DTOs.Chamado
{
    public class ChamadoCreateDto
    {
        [Required(ErrorMessage = "A matrícula do colaborador é obrigatória")]
        [Range(1, 999999, ErrorMessage = "A matrícula deve ser um número de até 6 dígitos")]
        public int MatriculaColaborador { get; set; }

        [Required(ErrorMessage = "O tipo do chamado é obrigatório")]
        [EnumDataType(typeof(TipoChamado), ErrorMessage = "O tipo do chamado informado é inválido")]
        public TipoChamado TipoChamado { get; set; }

        [Required(ErrorMessage = "A descrição do chamado é obrigatória")]
        [StringLength(1000, MinimumLength = 5, ErrorMessage = "A descrição deve ter entre 5 e 1000 caracteres")]
        public string Descricao { get; set; } = string.Empty;
    }
}
