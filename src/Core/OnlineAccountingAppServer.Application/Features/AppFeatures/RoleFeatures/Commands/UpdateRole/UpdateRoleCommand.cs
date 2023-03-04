using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public sealed record UpdateRoleCommand(
        string Id,
        string Code,
        string Name) : ICommand<UpdateRoleCommandResponse>;
}
