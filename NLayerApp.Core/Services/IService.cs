using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.Services
{
    public interface IService<T> where T : class
    {

        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
        Task<T> AddAsync(T entity, CancellationToken cancellationToken);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
        Task UpdateAsync(T entity,CancellationToken cancellationToken);
        Task RemoveAsync(T entity, CancellationToken cancellationToken);
        Task RemoveRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
    }
}
