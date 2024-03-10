using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Core.IntRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        T Update(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> Where (Expression<Func<T, bool>> predicate);
    }
}
