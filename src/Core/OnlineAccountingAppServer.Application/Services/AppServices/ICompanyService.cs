using OnlineAccountingAppServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingAppServer.Domain.AppEntities;

namespace OnlineAccountingAppServer.Application.Services.AppServices
{
    public interface ICompanyService
    {
        Task CreateCompany(CreateCompanyCommand request);
        Task MigrateCompanyDatabases();
        Task<Company?> GetCompanyByName(string name);
    }
}
