using OnlineAccountingAppServer.Application.Messaging;
using OnlineAccountingAppServer.Application.Services.CompanyServices;

namespace OnlineAccountingAppServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed class CreateUCAFCommandHandler : ICommandHandler<CreateUCAFCommand, CreateUCAFCommandResponse>
    {
        private readonly IUCAFService _ucafService;

        public CreateUCAFCommandHandler(IUCAFService ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<CreateUCAFCommandResponse> Handle(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            await _ucafService.CreateUcafAsync(request);
            return new();
        }
    }
}
