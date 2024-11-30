using CseHelp.DataAccess;
using CseHelp.Models.Entities;
using CseHelp.Services.Interfaces;

namespace CseHelp.Services.Services
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
