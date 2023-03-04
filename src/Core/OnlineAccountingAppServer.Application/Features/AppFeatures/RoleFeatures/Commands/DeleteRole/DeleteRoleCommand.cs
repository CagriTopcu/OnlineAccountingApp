using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed record DeleteRoleCommand(
        string Id) : ICommand<DeleteRoleCommandResponse>;
}
