using MediatR;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public sealed class MigrateCompanyDatabasesRequest : IRequest<MigrateCompanyDatabasesResponse>
    {
    }
}
