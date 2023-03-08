using OnlineAccountingAppServer.Application.Messaging;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;
using OnlineAccountingAppServer.Domain.Roles;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles;

public sealed class CreateAllRolesCommandHandler : ICommandHandler<CreateAllRolesCommand, CreateAllRolesCommandResponse>
{
    private readonly IRoleService _roleService;

    public CreateAllRolesCommandHandler(IRoleService roleService)
    {
        _roleService = roleService;
    }

    public async Task<CreateAllRolesCommandResponse> Handle(CreateAllRolesCommand request, CancellationToken cancellationToken)
    {
        IList<AppRole> originalRoleList = RoleList.GetStaticRoles();
        IList<AppRole> newRoleList = new List<AppRole>();

        foreach (AppRole role in originalRoleList)
        {
            AppRole checkRole = await _roleService.GetByCodeAsync(role.Code);
            if (checkRole is null) newRoleList.Add(role);
        }

        await _roleService.AddRangeAsync(newRoleList);
        return new();
    }
}
