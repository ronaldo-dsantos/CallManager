using CallManager.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace CallManager.Api.DTOs.Chamado
{
    public class ChamadoCreateDto
    {
        [Required(ErrorMessage = "A matrícula do colaborador é obrigatória")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "A matrícula do colaborador deve ser numérica e conter 6 dígitos")]
        public string? MatriculaColaborador { get; set; }

        [Required(ErrorMessage = "O tipo de solicitação é obrigatório")]
        [EnumDataType(typeof(TipoSolicitacao), ErrorMessage = "O tipo de solicitação é inválido")]        
        public TipoSolicitacao TipoSolicitacao { get; set; }

        [Required(ErrorMessage = "O campo detalhes é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo detalhes deve ter no máximo 1000 caracteres")]        
        public string? Detalhes { get; set; }
    }
}
