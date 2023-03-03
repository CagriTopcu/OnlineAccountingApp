using MediatR;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public sealed class UpdateRoleHandler : IRequestHandler<UpdateRoleRequest, UpdateRoleResponse>
    {
        private readonly IRoleService _roleService;

        public UpdateRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<UpdateRoleResponse> Handle(UpdateRoleRequest request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetByIdAsync(request.Id);
            if (role == null) throw new Exception("Rol bulunamadı!");

            if(role.Code != request.Code)
            {
                AppRole checkCode = await _roleService.GetByCodeAsync(request.Code);

                if (checkCode is not null) throw new Exception("Bu kod daha önce kaydedilmiş!");
            }

            role.Code = request.Code;
            role.Name = request.Name;
            await _roleService.UpdateAsync(role);

            return new();
        }
    }
}
