using OnlineAccountingAppServer.Domain.AppEntities;
using OnlineAccountingAppServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using OnlineAccountingAppServer.Persistence.Repositories.GenericRepositories.AppDbContext;

namespace OnlineAccountingAppServer.Persistence.Repositories.AppDbContext.MainRoleRepositories;

public sealed class MainRoleQueryRepository : AppQueryRepository<MainRole>, IMainRoleQueryRepository
{
    public MainRoleQueryRepository(Context.AppDbContext context) : base(context)
    {
    }
}
