using OnlineAccountingAppServer.Domain.CompanyEntities;
using OnlineAccountingAppServer.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace OnlineAccountingAppServer.Domain.Repositories.CompanyDbContext.UCAFRepositories
{
    public interface IUCAFCommandRepository : ICompanyDbCommandRepository<UniformChartOfAccount>
    {

    }
}
