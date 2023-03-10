using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;
using OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
using OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;
using OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole;
using OnlineAccountingAppServer.Presentation.Abstraction;

namespace OnlineAccountingAppServer.Presentation.Controllers;

public sealed class MainRolesController : ApiController
{
    public MainRolesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateMainRoleCommand request, CancellationToken cancellationToken)
    {
        CreateMainRoleCommandResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateStaticMainRoles(CancellationToken cancellationToken)
    {
        CreateStaticMainRolesCommand request = new(null);
        CreateStaticMainRolesCommandResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> GetAll(GetAllMainRoleQuery request)
    {
        GetAllMainRoleQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> RemoveById(RemoveByIdMainRoleCommand request)
    {
        RemoveByIdMainRoleCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Update(UpdateMainRoleCommand request)
    {
        UpdateMainRoleCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
