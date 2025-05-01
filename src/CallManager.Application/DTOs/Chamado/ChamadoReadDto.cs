using CallManager.Application.DTOs.Colaborador;
using CallManager.Application.Enums;

namespace CallManager.Application.DTOs.Chamado
{
    public class ChamadoReadDto
    {
        public int Id { get; set; }  
        public ColaboradorDto? Colaborador { get; set; }

        public TipoChamado Tipo { get; set; }
        public StatusChamado Status { get; set; }

        public string Descricao { get; set; } = string.Empty;
        public string? Tratativa { get; set; }

        public string AbertoPor { get; set; } = string.Empty;
        public DateTime DataAbertura { get; set; } = DateTime.UtcNow;

        public string? ConcluidoPor { get; set; }
        public DateTime? DataConclusao { get; set; }
    }
}
