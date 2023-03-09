using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Domain.Abstractions;
using OnlineAccountingAppServer.Domain.Repositories.GenericRepositories.CompanyDbContext;
using OnlineAccountingAppServer.Persistence.Context;
using System.Linq.Expressions;

namespace OnlineAccountingAppServer.Persistence.Repositories.GenericRepositories.CompanyDbContext
{
    public class CompanyDbQueryRepository<T> : ICompanyDbQueryRepository<T>
        where T : Entity
    {
        private static readonly Func<Context.CompanyDbContext, string, bool, Task<T>> GetByIdCompiled =
           EF.CompileAsyncQuery((Context.CompanyDbContext context, string id, bool isTracking) =>
           isTracking == true
             ? context.Set<T>().FirstOrDefault(p => p.Id == id)
             : context.Set<T>().AsNoTracking().FirstOrDefault(p => p.Id == id));

        private static readonly Func<Context.CompanyDbContext, bool, Task<T>> GetFirstCompiled =
           EF.CompileAsyncQuery((Context.CompanyDbContext context, bool isTracking) =>
           isTracking == true
           ? context.Set<T>().FirstOrDefault()
           : context.Set<T>().AsNoTracking().FirstOrDefault());

        private Context.CompanyDbContext _context;

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (Context.CompanyDbContext)context;
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

        public async Task<T> GetFirstByExpressionAsync(Expression<Func<T, bool>> expression, bool isTracking = true)
        {
            if (!isTracking)
                return await Entity.FirstOrDefaultAsync(expression);

            return await Entity.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true)
        {
            var result = Entity.Where(expression);
            if (!isTracking)
                result = result.AsNoTracking();

            return result;
        }
    }
}
