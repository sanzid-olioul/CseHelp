using CseHelp.DataAccess;
using CseHelp.Models.Entities;
using CseHelp.Services.Interfaces;

namespace CseHelp.Services.Services
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
