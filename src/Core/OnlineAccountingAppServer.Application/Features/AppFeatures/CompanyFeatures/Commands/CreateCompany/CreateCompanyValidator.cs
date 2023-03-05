using FluentValidation;

namespace OnlineAccountingAppServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;

public sealed class CreateCompanyValidator : AbstractValidator<CreateCompanyCommand>
{
    public CreateCompanyValidator()
    {
        RuleFor(p => p.DatabaseName).NotEmpty().WithMessage("Database bilgisi boş olamaz!");
        RuleFor(p => p.DatabaseName).NotNull().WithMessage("Database bilgisi boş olamaz!");
        RuleFor(p => p.ServerName).NotEmpty().WithMessage("Server bilgisi boş olamaz!");
        RuleFor(p => p.ServerName).NotNull().WithMessage("Server bilgisi boş olamaz!");
        RuleFor(p => p.Name).NotEmpty().WithMessage("Şirket adı boş olamaz!");
        RuleFor(p => p.Name).NotNull().WithMessage("Şirket adı boş olamaz!");
    }
}
