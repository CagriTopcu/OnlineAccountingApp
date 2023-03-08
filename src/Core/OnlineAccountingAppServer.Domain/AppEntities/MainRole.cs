using OnlineAccountingAppServer.Domain.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAccountingAppServer.Domain.AppEntities;

public sealed class MainRole : Entity
{
    public string Title { get; set; }
    public bool IsRoleCreatedByAdmin { get; set; }
    
    [ForeignKey("Company")]
    public string CompanyId { get; set; }
    public Company? Company { get; set; }
}
