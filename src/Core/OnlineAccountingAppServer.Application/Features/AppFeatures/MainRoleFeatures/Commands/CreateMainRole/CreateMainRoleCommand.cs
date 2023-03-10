using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;

public sealed record CreateMainRoleCommand(
    string Title,
    string CompanyId = null) : ICommand<CreateMainRoleCommandResponse>;
