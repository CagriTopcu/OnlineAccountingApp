using OnlineAccountingAppServer.Application.Abstractions;
using OnlineAccountingAppServer.Infrastructure.Authentication;

namespace OnlineAccountingAppServer.WebAPI.Configurations
{
    public class InfrastructureDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider, JwtProvider>();
        }
    }
}
