using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;
using OnlineAccountingAppServer.Persistence;
using OnlineAccountingAppServer.Persistence.Context;

namespace OnlineAccountingAppServer.WebAPI.Configurations
{
    public class PersistenceServiceInstaller : IServiceInstaller
    {
        private const string SectionName = "SqlServer";
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString(SectionName);

            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));
            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            services.AddAutoMapper(typeof(AssemblyReference).Assembly);
        }
    }
}
