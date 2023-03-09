using OnlineAccountingAppServer.Domain.CompanyEntities;
using OnlineAccountingAppServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineAccountingAppServer.Persistence.Repositories.GenericRepositories.CompanyDbContext;

namespace OnlineAccountingAppServer.Persistence.Repositories.CompanyDbContext.UCAFRepositories
{
    public sealed class UCAFQueryRepository : CompanyDbQueryRepository<UniformChartOfAccount>, IUCAFQueryRepository
    {
    }
}
