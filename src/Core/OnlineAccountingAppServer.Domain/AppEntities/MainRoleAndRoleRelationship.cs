using OnlineAccountingAppServer.Domain.Abstractions;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAccountingAppServer.Domain.AppEntities;

public sealed class MainRoleAndRoleRelationship : Entity
{
    [ForeignKey("AppRole")]
    public string RoleId { get; set; }
    public AppRole AppRole { get; set; }

    [ForeignKey("MainRole")]
    public string MainRoleId { get; set; }
    public MainRole MainRole { get; set; }
}
