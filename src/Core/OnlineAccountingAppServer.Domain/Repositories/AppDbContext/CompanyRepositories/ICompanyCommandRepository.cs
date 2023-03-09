using OnlineAccountingAppServer.Domain.AppEntities;
using OnlineAccountingAppServer.Domain.Repositories.GenericRepositories.AppDbContext;

namespace OnlineAccountingAppServer.Domain.Repositories.AppDbContext.CompanyRepositories;

public interface ICompanyCommandRepository : IAppCommandRepository<Company>
{
}
