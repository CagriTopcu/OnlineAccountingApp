using OnlineAccountingAppServer.Application.Messaging;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;

public class RemoveByIdMainRoleCommandHandler : ICommandHandler<RemoveByIdMainRoleCommand, RemoveByIdMainRoleCommandResponse>
{
    private readonly IMainRoleService _mainRoleService;

    public RemoveByIdMainRoleCommandHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    public async Task<RemoveByIdMainRoleCommandResponse> Handle(RemoveByIdMainRoleCommand request, CancellationToken cancellationToken)
    {
        await _mainRoleService.RemoveByIdAsync(request.Id);
        return new();
    }
}
