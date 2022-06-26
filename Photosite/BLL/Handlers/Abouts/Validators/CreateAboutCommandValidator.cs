using FluentValidation;
using Photosite.BLL.DTO.Abouts;

namespace Photosite.BLL.Handlers.Abouts.Validators
{
    public class CreateAboutCommandValidator: AbstractValidator<CreateAboutCommand>
    {
        public CreateAboutCommandValidator()
        {
            RuleFor(x => x.About.Title).NotEmpty();
            RuleFor(x => x.About.Text).NotEmpty();
            RuleFor(x => x.About.Image).NotEmpty();
        } // CreateAboutCommandValidator
    }
}
