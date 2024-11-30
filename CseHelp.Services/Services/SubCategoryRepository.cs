using CseHelp.DataAccess;
using CseHelp.Models.Entities;
using CseHelp.Services.Interfaces;

namespace CseHelp.Services.Services
{
    public class SubCategoryRepository : Repository<Category>, ICategoryRepository
    {
        public SubCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
