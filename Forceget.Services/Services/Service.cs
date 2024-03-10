using Forceget.Core.IntRepository;
using Forceget.Core.IntService;
using Forceget.Core.IntUnitOfWork;
using System.Linq.Expressions;

namespace Forceget.Services.Services
{
    public class Service<T> : IService<T> where T : class
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<T> _repository;
        public Service(IUnitOfWork unitOfWork,IRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public T Update(T entity)
        {
            _repository.Update(entity);
            _unitOfWork.Commit();
            return entity;
        }

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate)
        {
            return await _repository.Where(predicate);
        }
    }
}
