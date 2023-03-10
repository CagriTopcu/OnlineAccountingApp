using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities;
using OnlineAccountingAppServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using OnlineAccountingAppServer.Domain.UnitOfWorks;

namespace OnlineAccountingAppServer.Persistence.Services.AppServices;

public sealed class MainRoleService : IMainRoleService
{
    private readonly IMainRoleCommandRepository _mainRoleCommandRepository;
    private readonly IMainRoleQueryRepository _mainRoleQueryRepository;
    private readonly IAppUnitOfWork _unitOfWork;

    public MainRoleService(IMainRoleCommandRepository mainRoleCommandRepository, IMainRoleQueryRepository mainRoleQueryRepository, IAppUnitOfWork unitOfWork)
    {
        _mainRoleCommandRepository = mainRoleCommandRepository;
        _mainRoleQueryRepository = mainRoleQueryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken)
    {
        await _mainRoleCommandRepository.AddAsync(mainRole, cancellationToken);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task CreateRangeAsync(List<MainRole> mainRoles, CancellationToken cancellationToken)
    {
        await _mainRoleCommandRepository.AddRangeAsync(mainRoles, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public IQueryable<MainRole> GetAll()
    {
        return _mainRoleQueryRepository.GetAll();
    }

    public async Task<MainRole> GetByIdAsync(string id)
    {
        return await _mainRoleQueryRepository.GetByIdAsync(id);
    }

    public async Task<MainRole> GetByTitleAndCompanyIdAsync(string title, string companyId, CancellationToken cancellationToken)
    {
        return await _mainRoleQueryRepository.GetFirstByExpressionAsync(p => p.Title == title && p.CompanyId == companyId, cancellationToken, false);
    }

    public async Task RemoveByIdAsync(string id)
    {
        await _mainRoleCommandRepository.RemoveByIdAsync(id);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task UpdateAsync(MainRole mainRole)
    {
        _mainRoleCommandRepository.Update(mainRole);
        await _unitOfWork.SaveChangesAsync();
    }
}
