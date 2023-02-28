using OnlineAccountingAppServer.Domain.CompanyEntities;
using OnlineAccountingAppServer.Domain.Repositories.UCAFRepositories;

namespace OnlineAccountingAppServer.Persistence.Repositories.UCAFRepositories
{
    public sealed class UCAFCommandRepository : CommandRepository<UniformChartOfAccount>, IUCAFCommandRepository
    {

    }
}
