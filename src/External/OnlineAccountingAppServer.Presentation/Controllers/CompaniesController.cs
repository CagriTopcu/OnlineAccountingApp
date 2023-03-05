using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingAppServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingAppServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
using OnlineAccountingAppServer.Presentation.Abstraction;

namespace OnlineAccountingAppServer.Presentation.Controllers
{
    public class CompaniesController : ApiController
    {
        public CompaniesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            CreateCompanyCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateCompanyDatabases()
        {
            MigrateCompanyDatabasesCommand request = new();
            MigrateCompanyDatabasesCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
