using OnlineAccountingAppServer.Application.Messaging;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany;

public sealed record GetAllCompanyQuery() : IQuery<GetAllCompanyQueryResponse>;
