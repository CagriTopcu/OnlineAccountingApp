using OnlineAccountingAppServer.Domain.AppEntities;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole;

public sealed record GetAllMainRoleQueryResponse(
    IList<MainRole> MainRoles);
