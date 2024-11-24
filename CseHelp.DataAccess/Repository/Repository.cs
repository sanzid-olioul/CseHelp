using CseHelp.DataAccess.Data;
using CseHelp.DataAccess.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CseHelp.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task<IEnumerable<T>> Filter(Expression<Func<T, bool>> filter)
        {
             return await _context.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<T> Get(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().FindAsync(filter);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
