using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Entities.RedeSocialContext;

namespace ProEventos.Data.Mapping
{
    public class RedeSocialMap : IEntityTypeConfiguration<RedeSocialEntity>
    {
        public void Configure(EntityTypeBuilder<RedeSocialEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(n => n.Descricao)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(n => n.Url)
               .HasMaxLength(60)
               .IsRequired();

        }
    }
}
