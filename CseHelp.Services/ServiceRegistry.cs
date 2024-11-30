using CseHelp.DataAccess;
using CseHelp.Services.Interfaces;
using CseHelp.Services.Profiles;
using CseHelp.Services.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

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
            services.AddScoped<IUnitOfWork,UnitOfWork>();

            return services;
        }
    }
}
