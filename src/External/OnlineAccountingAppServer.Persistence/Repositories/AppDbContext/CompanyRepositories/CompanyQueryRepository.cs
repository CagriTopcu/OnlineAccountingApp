using OnlineAccountingAppServer.Domain.AppEntities;
using OnlineAccountingAppServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineAccountingAppServer.Persistence.Repositories.GenericRepositories.AppDbContext;

namespace OnlineAccountingAppServer.Persistence.Repositories.AppDbContext.CompanyRepositories;

public sealed class CompanyQueryRepository : AppQueryRepository<Company>, ICompanyQueryRepository
{
    public CompanyQueryRepository(Context.AppDbContext context) : base(context)
    {
    }
}
