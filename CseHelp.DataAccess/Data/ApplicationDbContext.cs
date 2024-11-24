using CseHelp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CseHelp.DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext) { }

        DbSet<Category> Categories { get; set; }
        DbSet<SubCategory> SubCategories { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Author> Author { get; set; }
        DbSet<Article> Articles { get; set; }
        DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
