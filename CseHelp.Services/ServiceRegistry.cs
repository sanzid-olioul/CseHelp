using CseHelp.DataAccess;
using CseHelp.Services.Command.QuoteCommand;
using CseHelp.Services.Profiles;
using CseHelp.Services.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CseHelp.Services
{
    public static class ServiceRegistry
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConn"));
            });

            services.AddAutoMapper(typeof(MappingProfiles));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AddOrUpdateQuoteCommand).GetTypeInfo().Assembly));
            return services;
        }
    }
}
