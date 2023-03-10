using OnlineAccountingAppServer.Domain.AppEntities;

namespace OnlineAccountingAppServer.Application.Services.AppServices;

public interface IMainRoleService
{
    Task<MainRole> GetByTitleAndCompanyIdAsync(string title, string companyId, CancellationToken cancellationToken);
    Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken);
    Task CreateRangeAsync(List<MainRole> mainRoles, CancellationToken cancellationToken);
    IQueryable<MainRole> GetAll();
    Task RemoveByIdAsync(string id);
    Task<MainRole> GetByIdAsync(string id);
    Task UpdateAsync(MainRole mainRole);
}
