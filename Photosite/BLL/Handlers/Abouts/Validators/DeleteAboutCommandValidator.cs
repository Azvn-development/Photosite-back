using FluentValidation;
using Photosite.BLL.DTO.Abouts;
using Photosite.DAL.Repositories.About;

namespace Photosite.BLL.Handlers.Abouts.Validators
{
    public class DeleteAboutCommandValidator : AbstractValidator<DeleteAboutCommand>
    {
        private readonly IAboutRepository _aboutRepository;

        public DeleteAboutCommandValidator(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;

            RuleFor(x => x.Id).MustAsync(async (x, token) =>
            {
                return await _aboutRepository.IsExist(x, token);
            }).WithMessage("About with current id not found");
        } // DeleteAboutCommandValidator
    }
}
