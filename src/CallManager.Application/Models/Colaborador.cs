namespace CallManager.Application.Models
{
    public class Colaborador : Entity
    {
        public int Matricula { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Gestor { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public string Setor { get; set; } = string.Empty;
        public string Turno { get; set; } = string.Empty;

        public ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();
    }
}
