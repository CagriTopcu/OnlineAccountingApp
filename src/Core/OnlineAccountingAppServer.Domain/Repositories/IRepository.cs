using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Domain.Abstractions;

namespace OnlineAccountingAppServer.Domain.Repositories
{
    public interface IRepository<T>
        where T : Entity
    {
        void SetDbContextInstance(DbContext context);
        DbSet<T> Entity { get; set; }
    }
}
