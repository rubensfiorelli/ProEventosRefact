using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProEventos.Data.Context;
using ProEventos.Data.Repositories.EventoContext;
using ProEventos.Domain.Contracts.EventoContext;

namespace TravelNet.CrossCutting
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(opts => opts
                    .UseMySql(configuration.GetConnectionString("DbConnection"),
                     ServerVersion.AutoDetect(configuration.GetConnectionString("DbConnection")),
                     b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));


            //Repositories
            services.AddScoped(typeof(IEventoRepository), typeof(EventoRepository));



            //Services
            //services.AddScoped(typeof(ILeadsService), typeof(LeadsService));


            return services;

        }
    }
}

