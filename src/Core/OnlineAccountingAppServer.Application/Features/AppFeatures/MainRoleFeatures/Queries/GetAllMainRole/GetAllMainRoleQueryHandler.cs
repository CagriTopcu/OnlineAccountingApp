using Microsoft.EntityFrameworkCore;
using OnlineAccountingAppServer.Application.Messaging;
using OnlineAccountingAppServer.Application.Services.AppServices;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole;

public sealed class GetAllMainRoleQueryHandler : IQueryHandler<GetAllMainRoleQuery, GetAllMainRoleQueryResponse>
{
    private readonly IMainRoleService _mainRoleService;

    public GetAllMainRoleQueryHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    public async Task<GetAllMainRoleQueryResponse> Handle(GetAllMainRoleQuery request, CancellationToken cancellationToken)
    {
        var result = await _mainRoleService.GetAll().ToListAsync();
        return new(result);
    }
}
