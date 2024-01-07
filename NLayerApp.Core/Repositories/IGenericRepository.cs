
using System.Linq.Expressions;


namespace NLayerApp.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T,bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression,CancellationToken cancellationToken);
        Task AddAsync(T entity,CancellationToken cancellationToken);
        Task AddRangeAsync(IEnumerable<T> entities,CancellationToken cancellationToken);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
