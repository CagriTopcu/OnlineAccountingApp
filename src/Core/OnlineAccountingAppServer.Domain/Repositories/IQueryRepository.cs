using OnlineAccountingAppServer.Domain.Abstractions;
using System.Linq.Expressions;

namespace OnlineAccountingAppServer.Domain.Repositories
{
    public interface IQueryRepository<T> : IRepository<T>
        where T : Entity
    {
        IQueryable<T> GetAll(bool isTracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true);
        Task<T> GetByIdAsync(string id, bool isTracking = true);
        Task<T> GetFirstByExpressionAsync(Expression<Func<T, bool>> expression, bool isTracking = true);
        Task<T> GetFirstAsync(bool isTracking = true);
    }
}
