using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;

public sealed record UpdateMainRoleCommand(
    string Id,
    string Title) : ICommand<UpdateMainRoleCommandResponse>;
