using FluentValidation;
using Photosite.BLL.DTO.Services;
using Photosite.DAL.Repositories.Service;

namespace Photosite.BLL.Handlers.Services.Validators
{
    public class DeleteServiceCommandValidator : AbstractValidator<DeleteServiceCommand>
    {
        private readonly IServiceRepository _serviceRepository;

        public DeleteServiceCommandValidator(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;

            RuleFor(x => x.Id).MustAsync(async (x, token) =>
            {
                return await _serviceRepository.IsExist(x, token);
            }).WithMessage("Service with current id not found");
        } // DeleteServiceCommandValidator
    }
}
