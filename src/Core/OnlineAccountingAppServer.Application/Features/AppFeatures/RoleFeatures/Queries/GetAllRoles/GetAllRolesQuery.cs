using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed record GetAllRolesQuery() :
        IQuery<GetAllRolesQueryResponse>;
}
