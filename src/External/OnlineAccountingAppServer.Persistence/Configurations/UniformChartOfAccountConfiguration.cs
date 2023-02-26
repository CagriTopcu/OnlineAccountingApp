using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineAccountingAppServer.Domain.CompanyEntities;
using OnlineAccountingAppServer.Persistence.Constants;

namespace OnlineAccountingAppServer.Persistence.Configurations
{
    public sealed class UniformChartOfAccountConfiguration : IEntityTypeConfiguration<UniformChartOfAccount>
    {
        public void Configure(EntityTypeBuilder<UniformChartOfAccount> builder)
        {
            builder.ToTable(TableNames.UniformChartOfAccounts);
            builder.HasKey(p => p.Id);
        }
    }
}
