using OnlineAccountingAppServer.Domain.AppEntities;
using OnlineAccountingAppServer.Domain.Repositories.GenericRepositories;

namespace OnlineAccountingAppServer.Domain.Repositories.AppDbContext.MainRoleRepositories;

public interface IMainRoleCommandRepository : ICommandGenericRepository<MainRole>
{
}
