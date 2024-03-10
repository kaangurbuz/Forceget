using System.Linq.Expressions;

namespace Forceget.Core.IntService
{
    public interface IService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        T Update(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate);
    }
}
