using Microsoft.EntityFrameworkCore;

namespace OnlineAccountingAppServer.Domain
{
    public interface IUnitOfWork
    {
        void SetDbContextInstance(DbContext context);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
