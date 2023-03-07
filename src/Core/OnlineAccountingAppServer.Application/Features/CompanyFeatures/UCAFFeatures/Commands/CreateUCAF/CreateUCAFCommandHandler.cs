using OnlineAccountingAppServer.Application.Messaging;
using OnlineAccountingAppServer.Application.Services.CompanyServices;
using OnlineAccountingAppServer.Domain.CompanyEntities;

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
            UniformChartOfAccount ucaf = await _ucafService.GetByCodeAsync(request.Code);

            if (ucaf is not null) throw new Exception("Bu hesap planı kodu daha önce tanımlanmış!");

            await _ucafService.CreateUcafAsync(request, cancellationToken);
            return new();
        }
    }
}
