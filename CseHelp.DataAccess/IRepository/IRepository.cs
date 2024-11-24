using System.Linq.Expressions;

namespace CseHelp.DataAccess.IRepository
{
    public interface IRepository<T> where T : class
    {
        public Task<T> Get(Expression<Func<T, bool>> filter);
        public Task<IEnumerable<T>> GetAll();
        public Task<IEnumerable<T>> Filter(Expression<Func<T,bool>> filter);
        public Task Add(T entity);
        public void Remove(T entity);
    }
}
