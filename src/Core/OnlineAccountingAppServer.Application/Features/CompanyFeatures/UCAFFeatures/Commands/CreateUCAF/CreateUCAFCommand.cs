using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed record CreateUCAFCommand(
        string Code,
        string Name,
        char Type,
        string CompanyId) : ICommand<CreateUCAFCommandResponse>;
}
