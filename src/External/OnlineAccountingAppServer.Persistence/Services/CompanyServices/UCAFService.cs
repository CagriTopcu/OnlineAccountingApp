using AutoMapper;
using OnlineAccountingAppServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineAccountingAppServer.Application.Services.CompanyServices;
using OnlineAccountingAppServer.Domain;
using OnlineAccountingAppServer.Domain.CompanyEntities;
using OnlineAccountingAppServer.Domain.Repositories.UCAFRepositories;
using OnlineAccountingAppServer.Persistence.Context;

namespace OnlineAccountingAppServer.Persistence.Services.CompanyServices
{
    public sealed class UCAFService : IUCAFService
    {
        private readonly IUCAFCommandRepository _commandRepository;
        private readonly IContextService _contextService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;

        public UCAFService(IUCAFCommandRepository commandRepository, IContextService contextService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateUcafAsync(CreateUCAFCommand request)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);

            UniformChartOfAccount uniformChartOfAccount = _mapper.Map<UniformChartOfAccount>(request);
            uniformChartOfAccount.Id = Guid.NewGuid().ToString();

            await _commandRepository.AddAsync(uniformChartOfAccount);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
