using AutoMapper;
using Photosite.BLL.DTO.Services;
using Photosite.DAL.Entities;
using Photosite.DAL.Repositories.Service;

namespace Photosite.BLL.Handlers.Services.Handlers
{
    public class CreateServiceHandler: IBaseHandler<CreateServiceCommand, CreateServiceResponse>
    {
        private readonly IServiceRepository _serviceRepository;
        private IMapper _mapper;

        public CreateServiceHandler(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        } // CreateServiceHandler

        public async Task<CreateServiceResponse> Handle(CreateServiceCommand command, CancellationToken token)
        {
            var service = _mapper.Map<ServiceEntity>(command.Service);

            _serviceRepository.Add(service);
            await _serviceRepository.SaveChangesAsync(token);

            return new CreateServiceResponse
            {
                Id = service.Id
            };
        } // Handle
    }
}
