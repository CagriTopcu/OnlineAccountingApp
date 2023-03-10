using AutoMapper;
using OnlineAccountingAppServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineAccountingAppServer.Application.Services.CompanyServices;
using OnlineAccountingAppServer.Domain;
using OnlineAccountingAppServer.Domain.CompanyEntities;
using OnlineAccountingAppServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineAccountingAppServer.Domain.UnitOfWorks;
using OnlineAccountingAppServer.Persistence.Context;

namespace OnlineAccountingAppServer.Persistence.Services.CompanyServices
{
    public sealed class UCAFService : IUCAFService
    {
        private readonly IUCAFCommandRepository _commandRepository;
        private readonly IUCAFQueryRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;

        public UCAFService(IUCAFCommandRepository commandRepository, IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, IUCAFQueryRepository queryRepository)
        {
            _commandRepository = commandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _queryRepository = queryRepository;
        }

        public async Task CreateUcafAsync(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);

            UniformChartOfAccount uniformChartOfAccount = _mapper.Map<UniformChartOfAccount>(request);
            uniformChartOfAccount.Id = Guid.NewGuid().ToString();

            await _commandRepository.AddAsync(uniformChartOfAccount, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<UniformChartOfAccount> GetByCodeAsync(string code, CancellationToken cancellationToken)
        {
            return await _queryRepository.GetFirstByExpressionAsync(p => p.Code == code, cancellationToken);
        }
    }
}
