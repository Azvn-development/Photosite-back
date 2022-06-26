using FluentValidation;
using Photosite.BLL.DTO.Abouts;
using Photosite.DAL.Repositories.About;

namespace Photosite.BLL.Handlers.Abouts.Validators
{
    public class UpdateAboutCommandValidator : AbstractValidator<UpdateAboutCommand>
    {
        private readonly IAboutRepository _aboutRepository;

        public UpdateAboutCommandValidator(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;

            RuleFor(x => x.About.Id).MustAsync(async (x, token) =>
            {
                return await _aboutRepository.IsExist(x, token);
            }).WithMessage("About with current id not found");

            RuleFor(x => x.About.Title).NotEmpty();
            RuleFor(x => x.About.Text).NotEmpty();
            RuleFor(x => x.About.Image).NotEmpty();
        } // UpdateAboutCommandValidator
    }
}
