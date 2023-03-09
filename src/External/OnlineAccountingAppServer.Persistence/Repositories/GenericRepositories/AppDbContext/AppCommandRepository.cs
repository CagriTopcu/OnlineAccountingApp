using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Domain.Abstractions;
using OnlineAccountingAppServer.Domain.Repositories.GenericRepositories.AppDbContext;

namespace OnlineAccountingAppServer.Persistence.Repositories.GenericRepositories.AppDbContext;

public class AppCommandRepository<T> : IAppCommandRepository<T>
    where T : Entity
{
    private static readonly Func<Context.AppDbContext, string, Task<T>> GetByIdCompiled =
            EF.CompileAsyncQuery((Context.AppDbContext context, string id) =>
            context.Set<T>().FirstOrDefault(p => p.Id == id));

    private readonly Context.AppDbContext _context;

    public AppCommandRepository(Context.AppDbContext context)
    {
        _context = context;
        Entity = _context.Set<T>();
    }

    public DbSet<T> Entity { get; set; }

    public async Task AddAsync(T entity, CancellationToken cancellationToken)
    {
        await Entity.AddAsync(entity, cancellationToken);
    }

    public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
    {
        await Entity.AddRangeAsync(entities, cancellationToken);
    }

    public void Remove(T entity)
    {
        Entity.Remove(entity);
    }

    public async Task RemoveByIdAsync(string id)
    {
        T entity = await GetByIdCompiled(_context, id);
        Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        Entity.RemoveRange(entities);
    }

    public void Update(T entity)
    {
        Entity.Update(entity);
    }

    public void UpdateRange(IEnumerable<T> entities)
    {
        Entity.UpdateRange(entities);
    }
}
