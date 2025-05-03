using System.ComponentModel.DataAnnotations;

namespace CallManager.Application.DTOs.Colaborador
{
    public class ColaboradorDto
    {
        [Required(ErrorMessage = "A matrícula do colaborador é obrigatória.")]
        [Range(1, 999999, ErrorMessage = "A matrícula deve ser um número entre 1 e 999999.")]
        public int Matricula { get; set; }

        [Required(ErrorMessage = "O nome do colaborador é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O nome do gestor é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome do gestor deve ter entre 2 e 100 caracteres.")]
        public string Gestor { get; set; } = string.Empty;

        [Required(ErrorMessage = "O cargo do colaborador é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O cargo deve ter entre 2 e 100 caracteres.")]
        public string Cargo { get; set; } = string.Empty;

        [Required(ErrorMessage = "O setor do colaborador é obrigatório.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O setor deve ter entre 2 e 50 caracteres.")]
        public string Setor { get; set; } = string.Empty;

        [Required(ErrorMessage = "O turno do colaborador é obrigatório.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O turno deve ter entre 2 e 50 caracteres.")]
        public string Turno { get; set; } = string.Empty;
    }
}
