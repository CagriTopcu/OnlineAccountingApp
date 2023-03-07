using Moq;
using OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineAccountingAppServer.UnitTest.Features.AppFeatures.RoleFeatures.Queries;

public sealed class GetAllRolesQueryUnitTest
{
    private readonly Mock<IRoleService> _roleService;

    public GetAllRolesQueryUnitTest()
    {
        _roleService = new();    
    }

    [Fact]
    public async Task GetAllRolesQueryResponseShouldNotBeNull()
    {
        _roleService.Setup(
            x => x.GetAllRolesAsync())
            .ReturnsAsync(new List<AppRole>());
    }
}
