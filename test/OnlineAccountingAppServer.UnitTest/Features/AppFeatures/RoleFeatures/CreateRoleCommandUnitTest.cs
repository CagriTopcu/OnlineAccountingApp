using Moq;
using OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineAccountingAppServer.UnitTest.Features.AppFeatures.RoleFeatures;

public sealed class CreateRoleCommandUnitTest
{
    private readonly Mock<IRoleService> _roleService;

    public CreateRoleCommandUnitTest()
    {
        _roleService = new();
    }

    [Fact]
    public async Task AppRoleShouldBeNull()
    {
        AppRole appRole = await _roleService.Object.GetByCodeAsync("UCAF.Create");
        appRole.ShouldBeNull();
    }

    [Fact]
    public async Task CreateRoleCommandResponseShouldNotBeNull()
    {
        var command = new CreateRoleCommand(Code: "UCAF.Create", Name: "Hesap Planı Kayıt Ekleme");

        var handler = new CreateRoleCommandHandler(_roleService.Object);

        CreateRoleCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
