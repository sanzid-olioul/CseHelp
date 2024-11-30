using AutoMapper;
using CseHelp.DataAccess;
using CseHelp.Services.Interfaces;

namespace CseHelp.Services.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        public IQuoteRepository Quote { get; private set; }
        protected ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            Quote = new QuoteRepository(dbContext,mapper);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
