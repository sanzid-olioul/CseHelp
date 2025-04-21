using CSEhelp.Data;
using CSEhelp.Entities;
using CSEhelp.Interfaces;
using CSEhelp.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CSEhelp.Utilities
{
    public static class ServiceRegistry
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(AppSettings.Settings.ConnectionString);
            }).AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 8;
                options.User.RequireUniqueEmail = true;
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.SignIn.RequireConfirmedEmail = true;
            }).AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            services.AddScoped<IAuthRepository, AuthRepository>();

            services.AddScoped<IAdminSeeder, AdminSeeder>();


            return services;
        }

        public interface IAdminSeeder
        {
            Task SeedAdminUserAsync();
        }

        public class AdminSeeder : IAdminSeeder
        {
            private readonly UserManager<AppUser> _userManager;
            private readonly RoleManager<AppRole> _roleManager;

            public AdminSeeder(
                UserManager<AppUser> userManager,
                RoleManager<AppRole> roleManager,
                IConfiguration configuration)
            {
                _userManager = userManager;
                _roleManager = roleManager;
            }

            public async Task SeedAdminUserAsync()
            {
                var adminRole = new AppRole
                {
                    Name = "admin",
                    RollDescription = "It is for the admin users only"
                };

                if (!await _roleManager.RoleExistsAsync(adminRole.Name))
                {
                    await _roleManager.CreateAsync(adminRole);
                }

                var adminUser = await _userManager.FindByEmailAsync(AppSettings.Settings.AdminEmail);
                if (adminUser == null)
                {
                    adminUser = new AppUser
                    {
                        UserName = AppSettings.Settings.AdminEmail,
                        Email = AppSettings.Settings.AdminEmail,
                        EmailConfirmed = true,
                        FirstName = AppSettings.Settings.AdminFirstName,
                        LastName = AppSettings.Settings.AdminLastName,
                    };

                    var result = await _userManager.CreateAsync(adminUser, AppSettings.Settings.AdminPassword);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(adminUser, adminRole.Name);
                    }
                }
            }
        }
    }
}
