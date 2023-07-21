using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProEventos.Domain.Entities.UserContext;

namespace ProEventos.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.Property(n => n.PrimeiroNome)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(n => n.UltimoNome)
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(n => n.Email)
              .HasMaxLength(50)
              .IsRequired();

            builder.Property(n => n.WhatsApp)
              .HasMaxLength(12)
              .IsRequired();
        }
    }
}
