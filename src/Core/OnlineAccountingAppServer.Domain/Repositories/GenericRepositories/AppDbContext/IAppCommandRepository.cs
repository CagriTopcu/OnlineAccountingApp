using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Domain.Abstractions;

namespace OnlineAccountingAppServer.Domain.Repositories.GenericRepositories.AppDbContext;

public interface IAppCommandRepository<T> : ICommandGenericRepository<T>, IRepository<T>
    where T : Entity
{
    public DbSet<T> Entity { get; set; }
}
