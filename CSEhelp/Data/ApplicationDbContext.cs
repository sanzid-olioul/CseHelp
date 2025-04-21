using CSEhelp.Data.Configurations;
using CSEhelp.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CSEhelp.Data
{
    public class ApplicationDbContext: IdentityDbContext<AppUser, AppRole, Guid, IdentityUserClaim<Guid>,
        AppUserRole, IdentityUserLogin<Guid> ,IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // User Congifurations
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new AppRoleConfiguration());
            builder.ApplyConfiguration(new AppUserRoleConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new TopicConfiguration());
            builder.ApplyConfiguration(new ArticleConfiguration());
        }

        public Article Article { get; set; }
        public Category Category { get; set; }
        public Topic Topic { get; set; }
        public Comment Comment { get; set; }
        public Reaply Reaply { get; set; }
    }
}
