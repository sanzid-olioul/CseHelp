using CseHelp.Services.Interfaces;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using CseHelp.DataAccess;

namespace CseHelp.Services.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T?> Get(Expression<Func<T,bool>> filert)
        {
            return await _dbContext.Set<T>().Where(filert).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> Filter(Expression<Func<T, bool>> filert)
        {
            return await _dbContext.Set<T>().Where(filert).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(int pageNo=1, int pageSize=10)
        {
            var res = await _dbContext.Set<T>().Skip((pageNo-1)* pageSize).Take(pageSize).ToListAsync();
            if (res.Count > 0)
            {
                return res;
            }

            return new List<T>();
        }

        public async Task Create(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }
    }
}
