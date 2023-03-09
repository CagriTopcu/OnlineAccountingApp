using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Application.Services.CompanyServices;
using OnlineAccountingAppServer.Persistence.Services.AppServices;
using OnlineAccountingAppServer.Persistence.Services.CompanyServices;
using OnlineAccountingAppServer.Persistence;
using OnlineAccountingAppServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineAccountingAppServer.Persistence.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineAccountingAppServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineAccountingAppServer.Persistence.Repositories.AppDbContext.CompanyRepositories;
using OnlineAccountingAppServer.Domain.UnitOfWorks;
using OnlineAccountingAppServer.Domain;
using OnlineAccountingAppServer.Persistence.UnitOfWorks;

namespace OnlineAccountingAppServer.WebAPI.Configurations
{
    public class PersistenceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitOfWork
            services.AddScoped<IContextService, ContextService>();
            services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
            services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
            #endregion

            #region Services
                #region CompanyDbContext
                services.AddScoped<IUCAFService, UCAFService>();
                #endregion

                #region AppDbContext
                services.AddScoped<ICompanyService, CompanyService>();
                services.AddScoped<IRoleService, RoleService>();
                #endregion
            #endregion

            #region Repositories
                #region CompanyDbContext
                services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
                services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
                #endregion

                #region AppDbContext
                services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
                services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
                #endregion
            #endregion
        }
    }
}
