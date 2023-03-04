using OnlineAccountingAppServer.Application.Messaging;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed class GetAllRolesQueryHandler : IQueryHandler<GetAllRolesQuery, GetAllRolesQueryResponse>
    {
        private readonly IRoleService _roleService;

        public GetAllRolesQueryHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<GetAllRolesQueryResponse> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            IList<AppRole> roles = await _roleService.GetAllRolesAsync();

            return new GetAllRolesQueryResponse(roles);
        }
    }
}
