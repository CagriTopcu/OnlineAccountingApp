using OnlineAccountingAppServer.Domain.Abstractions;
using System.Linq.Expressions;

namespace OnlineAccountingAppServer.Domain.Repositories
{
    public interface IQueryRepository<T> : IRepository<T>
        where T : Entity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(string id);
        Task<T> GetFirstByExpressionAsync(Expression<Func<T, bool>> expression);
        Task<T> GetFirstAsync();
    }
}
