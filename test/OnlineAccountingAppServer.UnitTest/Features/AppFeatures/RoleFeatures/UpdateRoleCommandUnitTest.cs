using Moq;
using OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineAccountingAppServer.UnitTest.Features.AppFeatures.RoleFeatures;

public sealed class UpdateRoleCommandUnitTest
{
    private readonly Mock<IRoleService> _roleService;

    public UpdateRoleCommandUnitTest()
    {
        _roleService = new();
    }

    [Fact]
    public async Task AppRoleShouldNotBeNull()
    {
        _ = _roleService.Setup(
            x => x.GetByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new AppRole());
    }

    [Fact]
    public async Task AppRoleCodeShouldBeUnique()
    {
        AppRole checkRoleCode = await _roleService.Object.GetByCodeAsync("UCAF.Create");
        checkRoleCode.ShouldBeNull();
    }

    [Fact]
    public async Task UpdateRoleCommandResponseShouldNotBeNull()
    {
        var command = new UpdateRoleCommand(
            Id: "a7310bcc-3286-45e7-9c64-00fcdf9c6a72",
            Code: "UCAF.Create",
            Name: "Hesap Planı Kayıt Ekleme");

        _roleService.Setup(
            x => x.GetByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new AppRole());

        var handler = new UpdateRoleCommandHandler(_roleService.Object);

        UpdateRoleCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
