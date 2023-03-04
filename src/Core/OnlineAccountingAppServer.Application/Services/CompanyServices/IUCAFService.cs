using OnlineAccountingAppServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;

namespace OnlineAccountingAppServer.Application.Services.CompanyServices
{
    public interface IUCAFService
    {
        Task CreateUcafAsync(CreateUCAFCommand request);
    }
}
