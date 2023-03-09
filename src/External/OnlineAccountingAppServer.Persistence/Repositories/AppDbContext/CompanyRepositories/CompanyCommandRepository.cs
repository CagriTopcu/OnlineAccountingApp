using OnlineAccountingAppServer.Domain.AppEntities;
using OnlineAccountingAppServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineAccountingAppServer.Persistence.Repositories.GenericRepositories.AppDbContext;

namespace OnlineAccountingAppServer.Persistence.Repositories.AppDbContext.CompanyRepositories;

public sealed class CompanyCommandRepository : AppCommandRepository<Company>, ICompanyCommandRepository
{
    public CompanyCommandRepository(Context.AppDbContext context) : base(context)
    {
    }
}
