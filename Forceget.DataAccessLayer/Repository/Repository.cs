using Forceget.Core.IntRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Forceget.DataAccessLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ForcegetDBContext _context;
        public readonly DbSet<T> _dbSet;
        public Repository(ForcegetDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }
}
