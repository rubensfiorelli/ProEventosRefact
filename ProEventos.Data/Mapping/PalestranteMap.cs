using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Entities.EventoContext;

namespace ProEventos.Data.Mapping
{
    public class PalestranteMap : IEntityTypeConfiguration<PalestranteEntity>
    {
        public void Configure(EntityTypeBuilder<PalestranteEntity> builder)
        {
            builder.ToTable("Palestrantes");

            builder.HasKey(e => e.Id);

            builder.Property(n => n.Descricao)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
