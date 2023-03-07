using Moq;
using OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineAccountingAppServer.UnitTest.Features.AppFeatures.RoleFeatures.Commands;

public sealed class DeleteRoleCommandUnitTest
{
    private readonly Mock<IRoleService> _roleService;

    public DeleteRoleCommandUnitTest()
    {
        _roleService = new();
    }

    [Fact]
    public async Task AppRoleShouldNotBeNull()
    {
        _roleService.Setup(
            x => x.GetByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new AppRole());
    }

    [Fact]
    public async Task DeleteRoleCommandResponseShouldNotBeNull()
    {
        var command = new DeleteRoleCommand(
            Id: "a7310bcc-3286-45e7-9c64-00fcdf9c6a72");

        _roleService.Setup(
            x => x.GetByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new AppRole());

        var handler = new DeleteRoleCommandHandler(_roleService.Object);

        DeleteRoleCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
