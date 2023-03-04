using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed record CreateCompanyCommand(
        string Name,
        string ServerName,
        string DatabaseName,
        string UserId,
        string Password) : ICommand<CreateCompanyCommandResponse>;
  
}
