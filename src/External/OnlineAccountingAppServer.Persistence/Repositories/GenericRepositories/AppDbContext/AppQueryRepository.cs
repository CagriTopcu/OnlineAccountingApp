using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Domain.Abstractions;
using OnlineAccountingAppServer.Domain.Repositories.GenericRepositories.AppDbContext;
using System.Linq.Expressions;

namespace OnlineAccountingAppServer.Persistence.Repositories.GenericRepositories.AppDbContext;

public class AppQueryRepository<T> : IAppQueryRepository<T>
    where T : Entity
{
    private static readonly Func<Context.AppDbContext, string, bool, Task<T>> GetByIdCompiled =
          EF.CompileAsyncQuery((Context.AppDbContext context, string id, bool isTracking) =>
            context.Set<T>().FirstOrDefault(p => p.Id == id));

    private static readonly Func<Context.AppDbContext, bool, Task<T>> GetFirstCompiled =
       EF.CompileAsyncQuery((Context.AppDbContext context, bool isTracking) =>
        context.Set<T>().FirstOrDefault());

    private Context.AppDbContext _context;

    public AppQueryRepository(Context.AppDbContext context)
    {
        _context = context;
        Entity = _context.Set<T>();
    }

    public DbSet<T> Entity { get; set; }

    public void SetDbContextInstance(DbContext context)
    {
        _context = (Context.AppDbContext)context;
        Entity = _context.Set<T>();
    }

    public IQueryable<T> GetAll(bool isTracking = true)
    {
        var result = Entity.AsQueryable();
        if (!isTracking)
            result = result.AsNoTracking();

        return result;
    }

    public async Task<T> GetByIdAsync(string id, bool isTracking = true)
    {
        return await GetByIdCompiled(_context, id, isTracking);
    }

    public async Task<T> GetFirstAsync(bool isTracking = true)
    {
        return await GetFirstCompiled(_context, isTracking);
    }

    public async Task<T> GetFirstByExpressionAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken, bool isTracking = true)
    {
        if(!isTracking)
            return await Entity.FirstOrDefaultAsync(expression, cancellationToken);

        return await Entity.AsNoTracking().FirstOrDefaultAsync(expression, cancellationToken);
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true)
    {
        var result = Entity.Where(expression);
        if (!isTracking)
            result = result.AsNoTracking();

        return result;
    }
}
