using FluentValidation;
using Photosite.BLL.DTO.Services;
using Photosite.DAL.Repositories.Service;

namespace Photosite.BLL.Handlers.Services.Validators
{
    public class UpdateServiceCommandValidator : AbstractValidator<UpdateServiceCommand>
    {
        private readonly IServiceRepository _serviceRepository;

        public UpdateServiceCommandValidator(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;

            RuleFor(x => x.Service.Id).MustAsync(async (x, token) =>
            {
                return await _serviceRepository.IsExist(x, token);
            }).WithMessage("Service with current id not found");

            RuleFor(x => x.Service.Name).NotEmpty();
        } // UpdateServiceCommandValidator
    }
}
