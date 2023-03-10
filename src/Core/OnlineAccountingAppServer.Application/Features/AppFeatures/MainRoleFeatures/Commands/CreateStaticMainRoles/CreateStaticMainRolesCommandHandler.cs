using OnlineAccountingAppServer.Application.Messaging;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities;
using OnlineAccountingAppServer.Domain.Roles;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;

public sealed class CreateStaticMainRolesCommandHandler : ICommandHandler<CreateStaticMainRolesCommand, CreateStaticMainRolesCommandResponse>
{
    private readonly IMainRoleService _mainRoleService;

    public CreateStaticMainRolesCommandHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    public async Task<CreateStaticMainRolesCommandResponse> Handle(CreateStaticMainRolesCommand request, CancellationToken cancellationToken)
    {
        List<MainRole> mainRoles = RoleList.GetStaticMainRoles();
        List<MainRole> newMainRoles = new();

        foreach (var mainRole in mainRoles)
        {
            MainRole checkMainRole = await _mainRoleService.GetByTitleAndCompanyIdAsync(mainRole.Title, mainRole.CompanyId, cancellationToken);

            if (checkMainRole is null)
                newMainRoles.Add(mainRole);
        }

        await _mainRoleService.CreateRangeAsync(newMainRoles, cancellationToken);
        return new();
    }
}
