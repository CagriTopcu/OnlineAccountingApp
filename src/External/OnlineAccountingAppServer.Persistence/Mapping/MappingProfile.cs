using AutoMapper;
using OnlineAccountingAppServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingAppServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using OnlineAccountingAppServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineAccountingAppServer.Domain.AppEntities;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;
using OnlineAccountingAppServer.Domain.CompanyEntities;

namespace OnlineAccountingAppServer.Persistence.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCompanyCommand, Company>();
            CreateMap<CreateUCAFCommand, UniformChartOfAccount>();
            CreateMap<CreateRoleCommand, AppRole>();
        }
    }
}
