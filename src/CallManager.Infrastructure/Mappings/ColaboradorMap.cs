using CallManager.Application.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CallManager.Infrastructure.Mappings
{
    public class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("Colaboradores");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Matricula)
                   .IsRequired(); 

            builder.Property(c => c.Nome)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.Gestor)
                     .IsRequired()
                     .HasMaxLength(100);

            builder.Property(c => c.Cargo)
                     .IsRequired()
                     .HasMaxLength(50);

            builder.Property(c => c.Setor)
                        .IsRequired()
                        .HasMaxLength(50);

            builder.Property(c => c.Turno)
                        .IsRequired()
                        .HasMaxLength(50);

            builder.HasMany(c => c.Chamados)
                   .WithOne(c => c.Colaborador)
                   .HasForeignKey(c => c.ColaboradorId)
                   .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}
