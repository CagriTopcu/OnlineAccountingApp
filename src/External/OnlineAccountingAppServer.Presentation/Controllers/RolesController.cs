using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
using OnlineAccountingAppServer.Presentation.Abstraction;

namespace OnlineAccountingAppServer.Presentation.Controllers
{
    public class RolesController : ApiController
    {
        public RolesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateRole(CreateRoleRequest request)
        {
            CreateRoleResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            GetAllRolesRequest request = new();

            GetAllRolesResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleRequest request)
        {
            UpdateRoleResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteRoleRequest request = new()
            {
                Id = id
            };

            DeleteRoleResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
