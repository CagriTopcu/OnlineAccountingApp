using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed record CreateRoleCommand(
        string Code,
        string Name) : ICommand<CreateRoleCommandResponse>;
}
