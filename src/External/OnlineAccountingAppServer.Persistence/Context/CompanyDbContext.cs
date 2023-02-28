using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OnlineAccountingAppServer.Domain.Abstractions;
using OnlineAccountingAppServer.Domain.AppEntities;

namespace OnlineAccountingAppServer.Persistence.Context
{
    public sealed class CompanyDbContext : DbContext
    {
        private string ConnectionString = "";

        public CompanyDbContext(Company company = null)
        {
            if(company != null)
            {
                if (company.UserId is "")
                    ConnectionString = $"" +
                        $"Server={company.ServerName};" +
                        $"Database={company.DatabaseName};" +
                        $"User Id=sa;Password=123456A@;" +
                        $"Integrated Security=false;" +
                        $"TrustServerCertificate=true";
                else
                    ConnectionString = $"" +
                        $"Server={company.ServerName};" +
                        $"Database={company.DatabaseName};" +
                        $"User Id={company.UserId};" +
                        $"Password={company.Password};" +
                        $"Integrated Security=false;" +
                        $"TrustServerCertificate=true";
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);

        public class CompanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
        {
            public CompanyDbContext CreateDbContext(string[] args)
            {
                return new CompanyDbContext();
            }
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<Entity>();
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(p => p.CreatedDate)
                        .CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property(p => p.UpdatedDate)
                        .CurrentValue = DateTime.Now;
                }

            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
