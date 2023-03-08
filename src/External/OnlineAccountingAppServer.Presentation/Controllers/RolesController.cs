using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles;
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
        public async Task<IActionResult> CreateRole(CreateRoleCommand request)
        {
            CreateRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            GetAllRolesQuery request = new();

            GetAllRolesQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleCommand request)
        {
            UpdateRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteRoleCommand request = new(id);

            DeleteRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> CreateAllRoles()
        {
            CreateAllRolesCommand request = new();
            CreateAllRolesCommandResponse response = await _mediator.Send(request);
            
            return Ok(response);
        }
    }
}
