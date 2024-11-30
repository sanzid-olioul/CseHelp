using System.Linq.Expressions;

namespace CseHelp.Services.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T?> Get(Expression<Func<T, bool>> filter);
        Task<IEnumerable<T>> Filter(Expression<Func<T,bool>> filter);
        Task<IEnumerable<T>> GetAll(int pageNo, int pageSize);
        Task Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
