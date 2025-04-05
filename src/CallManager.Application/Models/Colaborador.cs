namespace CallManager.Application.Models
{
    public class Colaborador
    {
        public int Matricula { get; set; }
        public string? Nome { get; set; }
        public string? Gestor { get; set; }
        public string? Cargo { get; set; }
        public string? Bandeira { get; set; }
        public string? Turno { get; set; }

        // Relacionamento: Um Colaborador tem muitos Chamados
        public ICollection<Chamado>? Chamados { get; set; }
    }
}
