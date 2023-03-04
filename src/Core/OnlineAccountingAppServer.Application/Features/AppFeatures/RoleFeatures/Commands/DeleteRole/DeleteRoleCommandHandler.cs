using OnlineAccountingAppServer.Application.Messaging;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed class DeleteRoleCommandHandler : ICommandHandler<DeleteRoleCommand, DeleteRoleCommandResponse>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<DeleteRoleCommandResponse> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetByIdAsync(request.Id);

            if (role is null) throw new Exception("Rol bulunamadı!");

            await _roleService.DeleteAsync(role);
            return new();
        }
    }
}
