using OnlineAccountingAppServer.Application.Messaging;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;

public sealed class CreateMainRoleCommandHandler : ICommandHandler<CreateMainRoleCommand, CreateMainRoleCommandResponse>
{
    private readonly IMainRoleService _mainRoleService;

    public CreateMainRoleCommandHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    public async Task<CreateMainRoleCommandResponse> Handle(CreateMainRoleCommand request, CancellationToken cancellationToken)
    {
        MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndCompanyIdAsync(request.Title, request.CompanyId, cancellationToken);

        if (checkMainRoleTitle != null)
            throw new Exception("Bu rol daha önce kaydedilmiş!");

        MainRole mainRole = new(
            Guid.NewGuid().ToString(),
            request.Title,
            request.CompanyId != null ? false : true,
            request.CompanyId);

        await _mainRoleService.CreateAsync(mainRole, cancellationToken);
        return new();
    }
}
