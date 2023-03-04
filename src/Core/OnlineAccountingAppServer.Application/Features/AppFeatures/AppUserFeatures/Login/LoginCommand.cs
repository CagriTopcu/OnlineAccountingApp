using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed record LoginCommand(
        string EmailOrUserName,
        string Password) : ICommand<LoginCommandResponse>;
}
