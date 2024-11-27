using CseHelp.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace CseHelp.Web.ServiceRegistry
{
    public static class CustomServices
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConn"));
            });

            return services;
        }
    }
}
