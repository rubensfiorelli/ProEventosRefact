using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities.EventoContext;
using ProEventos.Domain.Entities.LoteContext;
using ProEventos.Domain.Entities.RedeSocialContext;
using ProEventos.Domain.Entities.UserContext;

namespace ProEventos.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<EventoEntity> Eventos { get; set; }
        public DbSet<PalestranteEntity> Palestrantes { get; set; }
        public DbSet<RedeSocialEntity> RedesSociais { get; set; }
        public DbSet<LoteEntity> Lotes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            //builder.Entity<EventoEntity>(new EventoMap().Configure);
            //builder.Entity<User>(new UserMap().Configure);
            //builder.Entity<PalestranteEntity>(new PalestranteMap().Configure);
            //builder.Entity<LoteEntity>(new LoteMap().Configure);
            //builder.Entity<RedeSocialEntity>(new RedeSocialMap().Configure);



            builder.Entity<User>()
                 .HasIndex(e => e.Email)
                 .IsUnique();

            builder.Entity<User>()
                   .ToTable("AspNetUsers")
                   .HasKey(e => e.Id);

        }
    }
}
