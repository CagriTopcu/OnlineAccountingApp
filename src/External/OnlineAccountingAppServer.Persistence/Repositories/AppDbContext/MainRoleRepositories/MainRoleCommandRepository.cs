using OnlineAccountingAppServer.Domain.AppEntities;
using OnlineAccountingAppServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using OnlineAccountingAppServer.Persistence.Repositories.GenericRepositories.AppDbContext;

namespace OnlineAccountingAppServer.Persistence.Repositories.AppDbContext.MainRoleRepositories;

public sealed class MainRoleCommandRepository : AppCommandRepository<MainRole>, IMainRoleCommandRepository
{
    public MainRoleCommandRepository(Context.AppDbContext context) : base(context)
    {
    }
}
