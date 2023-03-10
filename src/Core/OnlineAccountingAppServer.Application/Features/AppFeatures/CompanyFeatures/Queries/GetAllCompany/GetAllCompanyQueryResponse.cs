using OnlineAccountingAppServer.Domain.AppEntities;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany;

public sealed record GetAllCompanyQueryResponse(
    List<Company> Companies);
