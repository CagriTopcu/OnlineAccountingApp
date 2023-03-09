using Microsoft.EntityFrameworkCore;

namespace OnlineAccountingAppServer.Domain.UnitOfWorks
{
    public interface ICompanyDbUnitOfWork : IUnitOfWork
    {
        void SetDbContextInstance(DbContext context);
    }
}
