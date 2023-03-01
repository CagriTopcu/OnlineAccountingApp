using OnlineAccountingAppServer.Application;

namespace OnlineAccountingAppServer.WebAPI.Configurations
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(typeof(AssemblyReference).Assembly);
            });
        }
    }
}
