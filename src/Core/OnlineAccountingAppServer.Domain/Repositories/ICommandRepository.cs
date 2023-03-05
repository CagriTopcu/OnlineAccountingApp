using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Domain.Abstractions;

namespace OnlineAccountingAppServer.Domain.Repositories
{
    public interface ICommandRepository<T> : IRepository<T>
        where T : Entity
    {
        Task AddAsync(T entity, CancellationToken cancellationToken);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        Task RemoveByIdAsync(string id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
