using OnlineAccountingAppServer.Domain.Abstractions;

namespace OnlineAccountingAppServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDbQueryRepository<T> : ICompanyDbRepository<T>, IQueryGenericRepository<T>
        where T : Entity
    {
       
    }
}
