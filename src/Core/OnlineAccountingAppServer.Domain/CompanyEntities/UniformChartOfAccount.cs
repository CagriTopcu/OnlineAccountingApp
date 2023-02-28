using OnlineAccountingAppServer.Domain.Abstractions;

namespace OnlineAccountingAppServer.Domain.CompanyEntities
{
    public sealed class UniformChartOfAccount : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }
    }
}
