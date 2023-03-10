using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Application.Messaging;
using OnlineAccountingAppServer.Application.Services.AppServices;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany;

public sealed class GetAllCompanyQueryHandler : IQueryHandler<GetAllCompanyQuery, GetAllCompanyQueryResponse>
{
    private readonly ICompanyService _companyService;

    public GetAllCompanyQueryHandler(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    public async Task<GetAllCompanyQueryResponse> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
    {
        var result = await _companyService.GetAll().ToListAsync();
        return new(result);
    }
}
