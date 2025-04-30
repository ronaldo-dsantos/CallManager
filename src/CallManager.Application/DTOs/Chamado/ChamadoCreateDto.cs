using CallManager.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace CallManager.Api.DTOs.Chamado
{
    public class ChamadoCreateDto
    {
        [Required(ErrorMessage = "A matrícula do colaborador é obrigatória")]
        [Range(1, 999999, ErrorMessage = "A matrícula deve ter de 1 a 6 dígitos")]
        public int MatriculaColaborador { get; set; }

        [Required(ErrorMessage = "O tipo de solicitação é obrigatório")]
        [EnumDataType(typeof(TipoSolicitacao), ErrorMessage = "O tipo de solicitação é inválido")]
        public TipoSolicitacao TipoSolicitacao { get; set; }

        [Required(ErrorMessage = "O campo Detalhes da Solicitação é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo Detalhes da Solicitação deve ter no máximo 1000 caracteres")]
        public string DetalhesSolicitacao { get; set; } = string.Empty;
    }
}
