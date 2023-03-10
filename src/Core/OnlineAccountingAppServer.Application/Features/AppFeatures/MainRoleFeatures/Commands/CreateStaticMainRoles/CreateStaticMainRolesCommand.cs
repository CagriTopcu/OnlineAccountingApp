using OnlineAccountingAppServer.Application.Messaging;
using OnlineAccountingAppServer.Domain.AppEntities;
using System.Windows.Input;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;

public sealed record CreateStaticMainRolesCommand(
    List<MainRole> MainRoles) : ICommand<CreateStaticMainRolesCommandResponse>;
