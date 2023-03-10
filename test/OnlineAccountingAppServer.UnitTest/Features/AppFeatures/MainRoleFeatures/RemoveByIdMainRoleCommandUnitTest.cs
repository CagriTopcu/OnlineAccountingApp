using Moq;
using OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
using OnlineAccountingAppServer.Application.Services.AppServices;
using Shouldly;

namespace OnlineAccountingAppServer.UnitTest.Features.AppFeatures.MainRoleFeatures;

public sealed class RemoveByIdMainRoleCommandUnitTest
{
    private readonly Mock<IMainRoleService> _mainRoleService;

    public RemoveByIdMainRoleCommandUnitTest(Mock<IMainRoleService> mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    [Fact]
    public async Task RemoveByIdMainRoleCommandResponseShouldNotBeNull()
    {
        var command = new RemoveByIdMainRoleCommand(
            Id: "011afb4d-599c-47a2-9d31-0308d739211e");

        var handler = new RemoveByIdMainRoleCommandHandler(_mainRoleService.Object);

        RemoveByIdMainRoleCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
