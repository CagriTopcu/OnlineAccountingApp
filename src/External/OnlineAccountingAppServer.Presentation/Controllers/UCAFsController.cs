using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingAppServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineAccountingAppServer.Presentation.Abstraction;

namespace OnlineAccountingAppServer.Presentation.Controllers
{
    public sealed class UCAFsController : ApiController
    {
        public UCAFsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUCAF(CreateUCAFCommand request)
        {
            CreateUCAFCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
