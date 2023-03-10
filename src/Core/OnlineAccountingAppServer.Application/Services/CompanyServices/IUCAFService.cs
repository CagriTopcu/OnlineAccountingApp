using OnlineAccountingAppServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineAccountingAppServer.Domain.CompanyEntities;

namespace OnlineAccountingAppServer.Application.Services.CompanyServices
{
    public interface IUCAFService
    {
        Task CreateUcafAsync(CreateUCAFCommand request, CancellationToken cancellationToken);
        Task<UniformChartOfAccount> GetByCodeAsync(string code, CancellationToken cancellationToken);
    }
}
