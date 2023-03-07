using Moq;
using OnlineAccountingAppServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineAccountingAppServer.Application.Services.CompanyServices;
using OnlineAccountingAppServer.Domain.CompanyEntities;
using Shouldly;

namespace OnlineAccountingAppServer.UnitTest.Features.CompanyFeatures.Commands;

public sealed class CreateUCAFCommandUnitTest
{
    private readonly Mock<IUCAFService> _ucafService;

    public CreateUCAFCommandUnitTest()
    {
        _ucafService = new();
    }

    [Fact]
    public async Task UCAFShouldBeNull()
    {
        UniformChartOfAccount ucaf = await _ucafService.Object.GetByCodeAsync("100.01.001");
        ucaf.ShouldBeNull();
    }

    [Fact]
    public async Task CreateUCAFCommandResponseShouldNotBeNull()
    {
        var command = new CreateUCAFCommand(
            Code: "100.01.001",
            Name: "Kasa",
            Type: "M",
            CompanyId: "a7310bcc-3286-45e7-9c64-00fcdf9c6a72");

        var handler = new CreateUCAFCommandHandler(_ucafService.Object);

        CreateUCAFCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
