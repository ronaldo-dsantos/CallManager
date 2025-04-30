using System.ComponentModel.DataAnnotations;

namespace CallManager.Api.DTOs.Colaborador
{
    public class ColaboradorDto
    {
        [Key]
        public Guid Id { get; set; }

        [Range(1, 999999, ErrorMessage = "A matrícula deve conter entre 1 e 6 dígitos")]
        public int Matricula { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O Nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Gestor é obrigatório")]
        [StringLength(100, ErrorMessage = "O Gestor deve ter no máximo 100 caracteres")]
        public string Gestor { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Cargo é obrigatório")]
        [StringLength(100, ErrorMessage = "O Cargo deve ter no máximo 100 caracteres")]
        public string Cargo { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Setor é obrigatório")]
        [StringLength(100, ErrorMessage = "A Bandeira deve ter no máximo 100 caracteres")]
        public string Setor { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Turno é obrigatório")]
        [StringLength(100, ErrorMessage = "O Turno deve ter no máximo 100 caracteres")]
        public string Turno { get; set; } = string.Empty;
    }
}
