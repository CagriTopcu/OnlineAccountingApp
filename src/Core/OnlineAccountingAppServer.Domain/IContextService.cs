using Microsoft.EntityFrameworkCore;

namespace OnlineAccountingAppServer.Domain
{
    public interface IContextService
    {
        DbContext CreateDbContextInstance(string companyId);
    }
}
