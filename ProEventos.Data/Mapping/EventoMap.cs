using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Entities.EventoContext;

namespace ProEventos.Data.Mapping
{
    public class EventoMap : IEntityTypeConfiguration<EventoEntity>
    {
        public void Configure(EntityTypeBuilder<EventoEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(n => n.Descricao)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(n => n.Local)
               .HasMaxLength(20)
               .IsRequired();

        }
    }
}
