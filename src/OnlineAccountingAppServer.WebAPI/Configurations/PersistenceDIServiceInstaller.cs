using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Application.Services.CompanyServices;
using OnlineAccountingAppServer.Domain.Repositories.UCAFRepositories;
using OnlineAccountingAppServer.Domain;
using OnlineAccountingAppServer.Persistence.Repositories.UCAFRepositories;
using OnlineAccountingAppServer.Persistence.Services.AppServices;
using OnlineAccountingAppServer.Persistence.Services.CompanyServices;
using OnlineAccountingAppServer.Persistence;

namespace OnlineAccountingAppServer.WebAPI.Configurations
{
    public class PersistenceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitOfWork
            services.AddScoped<IContextService, ContextService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            #region Services
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IUCAFService, UCAFService>();
            #endregion

            #region Repositories
            services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
            services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
            #endregion
        }
    }
}
