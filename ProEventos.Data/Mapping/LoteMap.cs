using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Entities.LoteContext;

namespace ProEventos.Data.Mapping
{
    public class LoteMap : IEntityTypeConfiguration<LoteEntity>
    {
        public void Configure(EntityTypeBuilder<LoteEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(n => n.Descricao)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasPrecision(10, 2);

        }
    }
}
