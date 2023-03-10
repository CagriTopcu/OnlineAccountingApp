using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles;

public sealed record CreateStaticRolesCommand() : ICommand<CreateStaticRolesCommandResponse>;
