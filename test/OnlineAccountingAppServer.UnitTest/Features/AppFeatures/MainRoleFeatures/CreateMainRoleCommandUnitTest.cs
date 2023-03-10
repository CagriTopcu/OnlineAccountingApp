using Moq;
using OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using OnlineAccountingAppServer.Application.Services.AppServices;
using OnlineAccountingAppServer.Domain.AppEntities;
using Shouldly;

namespace OnlineAccountingAppServer.UnitTest.Features.AppFeatures.MainRoleFeatures;

public sealed class CreateMainRoleCommandUnitTest
{
    private readonly Mock<IMainRoleService> _mainRoleService;

    public CreateMainRoleCommandUnitTest()
    {
        _mainRoleService = new();
    }

    [Fact]
    public async Task MainRoleShouldBeNull()
    {
        MainRole mainRole = await _mainRoleService.Object.GetByTitleAndCompanyIdAsync(
            title: "Admin", 
            companyId: "b5274e1a-3a34-48c9-b515-6d63d2c72cc1", 
            cancellationToken: default);

        mainRole.ShouldBeNull();
    }

    [Fact]
    public async Task CreateMainRoleCommandResponseShouldNotBenull()
    {
        var command = new CreateMainRoleCommand(
            Title: "Admin",
            CompanyId: "b5274e1a-3a34-48c9-b515-6d63d2c72cc1");

        var handler = new CreateMainRoleCommandHandler(_mainRoleService.Object);

        CreateMainRoleCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
