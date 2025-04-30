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

            builder.Property(c => c.ColaboradorId)
                   .IsRequired();

            builder.Property(c => c.TipoSolicitacao)
                   .IsRequired();

            builder.Property(c => c.DetalhesSolicitacao)
                   .IsRequired()
                   .HasMaxLength(1000);

            builder.Property(c => c.Status)
                   .IsRequired();

            builder.Property(c => c.DataAbertura)
                   .IsRequired();
        }
    }    
}
