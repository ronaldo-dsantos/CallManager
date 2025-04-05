using Microsoft.EntityFrameworkCore;
using CallManager.Application.Models;
using CallManager.Infrastructure.Mappings;

namespace CallManager.Infrastructure.Data
{
    public class CallManagerDbContext : DbContext
    {
        public CallManagerDbContext(DbContextOptions<CallManagerDbContext> options) : base(options)
        {
        }

        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Chamado> Chamados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ColaboradorMap());
            modelBuilder.ApplyConfiguration(new ChamadoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
