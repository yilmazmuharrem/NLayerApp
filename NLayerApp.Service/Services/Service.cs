using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Repositories;
using NLayerApp.Core.Services;
using NLayerApp.Core.UnifOfWork;
using System.Linq.Expressions;


namespace NLayerApp.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {

        private readonly  IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(entity, cancellationToken);
            await  _unitOfWork.CommitAsync(cancellationToken);
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
        {
            await _repository.AddRangeAsync(entities, cancellationToken);
            await _unitOfWork.CommitAsync(cancellationToken);
            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
        {
            return await _repository.AnyAsync(expression, cancellationToken);
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(T entity, CancellationToken cancellationToken)
        {
            _repository.Remove(entity);
            await _unitOfWork.CommitAsync(cancellationToken);
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
        {
            _repository.RemoveRange(entities);
            await _unitOfWork.CommitAsync(cancellationToken);
        }

        public  async Task UpdateAsync(T entity, CancellationToken cancellationToken)
        {
             _repository.Update(entity);
            await _unitOfWork.CommitAsync(cancellationToken);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
           return _repository.Where(expression);
        }
    }
}
