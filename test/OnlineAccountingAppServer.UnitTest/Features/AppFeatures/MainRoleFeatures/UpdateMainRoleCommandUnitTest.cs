using Moq;
using OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities;
using Shouldly;

namespace OnlineAccountingAppServer.UnitTest.Features.AppFeatures.MainRoleFeatures;

public class UpdateMainRoleCommandUnitTest
{
    private readonly Mock<IMainRoleService> _mainRoleService;

    public UpdateMainRoleCommandUnitTest()
    {
        _mainRoleService = new();
    }

    [Fact]
    public async Task MainRoleShouldNotBeNull()
    {
        _mainRoleService
            .Setup(x => x.GetByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new MainRole());
    }

    [Fact]
    public async Task UpdateMainRoleCommandResponseShouldNotBeNull()
    {
        var command = new UpdateMainRoleCommand(
            Id: "011afb4d-599c-47a2-9d31-0308d739211e",
            Title: "Admin");

        var handler = new UpdateMainRoleCommandHandler(_mainRoleService.Object);

        _mainRoleService
            .Setup(x => x.GetByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new MainRole());

        UpdateMainRoleCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
