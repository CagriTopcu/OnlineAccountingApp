using FluentValidation;
using MediatR;
using OnlineAccountingAppServer.Application;
using OnlineAccountingAppServer.Application.Behavior;

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

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddValidatorsFromAssembly(typeof(AssemblyReference).Assembly);
        }
    }
}
