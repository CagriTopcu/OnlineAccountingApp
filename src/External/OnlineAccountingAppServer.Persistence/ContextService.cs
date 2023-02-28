using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Domain;
using OnlineAccountingAppServer.Domain.AppEntities;
using OnlineAccountingAppServer.Persistence.Context;

namespace OnlineAccountingAppServer.Persistence
{
    public sealed class ContextService : IContextService
    {
        private readonly AppDbContext _appDbContext;

        public ContextService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public DbContext CreateDbContextInstance(string companyId)
        {
            Company company = _appDbContext.Set<Company>().Find(companyId);
            return new CompanyDbContext(company);
        }
    }
}
