using OnlineAccountingAppServer.Domain.AppEntities.Identity;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed record GetAllRolesQueryResponse(
        IList<AppRole> Roles);
}
