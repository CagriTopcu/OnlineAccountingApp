using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed record MigrateCompanyDatabasesCommand() :
        ICommand<MigrateCompanyDatabasesCommandResponse>
    {
    }
}
