using CseHelp.DataAccess;
using CseHelp.Models.Entities;
using CseHelp.Services.Interfaces;

namespace CseHelp.Services.Services
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
