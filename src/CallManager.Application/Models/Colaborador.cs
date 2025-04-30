namespace CallManager.Application.Models
{
    public class Colaborador : Entity
    {
        public int Matricula { get; set; }
        public string? Nome { get; set; }
        public string? Gestor { get; set; }
        public string? Cargo { get; set; }
        public string? Bandeira { get; set; }
        public string? Turno { get; set; }

        public ICollection<Chamado>? Chamados { get; set; }
    }
}
