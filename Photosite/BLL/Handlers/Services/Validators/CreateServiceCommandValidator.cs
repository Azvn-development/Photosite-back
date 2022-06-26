using FluentValidation;
using Photosite.BLL.DTO.Services;

namespace Photosite.BLL.Handlers.Services.Validators
{
    public class CreateServiceCommandValidator: AbstractValidator<CreateServiceCommand>
    {
        public CreateServiceCommandValidator()
        {
            RuleFor(x => x.Service.Name).NotEmpty();
        } // CreateServiceCommandValidator
    }
}
