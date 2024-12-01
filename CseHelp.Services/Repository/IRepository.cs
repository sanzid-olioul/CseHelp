using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CseHelp.Services.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IList<T>> GetAllAsync();
        Task<List<T>> GetsAsync(params Expression<Func<T, object>>[] includes);
        Task<List<T>> GetsAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        Task<List<T>> GetsAsync(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
            params Expression<Func<T, object>>[] includes);
        Task<T> GetByIdAsync(Guid id);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        Task Insert(T entity);
        Task Update(T entity);
        Task<List<T>> UpdateListAsync(List<T> entityList);
        Task<bool> Delete(Guid id);
        Task SaveChangesAsync();
    }
}
