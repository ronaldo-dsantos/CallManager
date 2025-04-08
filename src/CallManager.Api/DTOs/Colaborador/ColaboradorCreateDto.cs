﻿using System.ComponentModel.DataAnnotations;

namespace CallManager.Api.DTOs.Colaborador
{
    public class ColaboradorCreateDto
    {
        [Key]
        [Range(1, 6)]
        public int Matricula { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? Gestor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? Cargo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? Bandeira { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? Turno { get; set; }
    }
}
