using CallManager.Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CallManager.Infrastructure.Mappings
{
    public class ChamadoMap : IEntityTypeConfiguration<Chamado>
    {
        public void Configure(EntityTypeBuilder<Chamado> builder)
        {
            builder.ToTable("Chamados");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.MatriculaColaborador)
                   .IsRequired();

            builder.Property(c => c.Tipo)
                   .IsRequired();

            builder.Property(c => c.Status)
                   .IsRequired();

            builder.Property(c => c.Descricao)
                   .IsRequired()
                   .HasMaxLength(1000);

            builder.Property(c => c.Tratativa)
                   .HasMaxLength(1000);

            builder.Property(c => c.AbertoPor)
                   .HasMaxLength(100);

            builder.Property(c => c.DataAbertura)
                   .IsRequired();

            builder.Property(c => c.ConcluidoPor)
                   .HasMaxLength(100);

            builder.HasOne(c => c.Colaborador)
                   .WithMany(c => c.Chamados)
                   .HasForeignKey(c => c.MatriculaColaborador)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }    
}
