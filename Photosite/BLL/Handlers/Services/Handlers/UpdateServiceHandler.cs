using AutoMapper;
using Photosite.BLL.DTO.Services;
using Photosite.DAL.Entities;
using Photosite.DAL.Repositories.Service;

namespace Photosite.BLL.Handlers.Services.Handlers
{
    public class UpdateServiceHandler: IBaseHandler<UpdateServiceCommand, UpdateServiceResponse>
    {
        private readonly IServiceRepository _serviceRepository;
        private IMapper _mapper;

        public UpdateServiceHandler(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        } // UpdateServiceHandler

        public async Task<UpdateServiceResponse> Handle(UpdateServiceCommand command, CancellationToken token)
        {
            var service = _mapper.Map<ServiceEntity>(command.Service);

            _serviceRepository.Update(service);
            await _serviceRepository.SaveChangesAsync(token);

            return new UpdateServiceResponse
            {
                Id = service.Id
            };
        } // Handle
    }
}
