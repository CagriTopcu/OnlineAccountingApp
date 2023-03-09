using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Domain.Abstractions;

namespace OnlineAccountingAppServer.Domain.Repositories.GenericRepositories;

public interface IRepository<T> 
    where T : Entity
{
    DbSet<T> Entity { get; set; }
}
