using Photosite.BLL.DTO.Services;
using Photosite.DAL.Entities;
using Photosite.DAL.Repositories.Service;

namespace Photosite.BLL.Handlers.Services.Handlers
{
    public class DeleteServiceHandler : IBaseHandler<DeleteServiceCommand, long>
    {
        private readonly IServiceRepository _serviceRepository;

        public DeleteServiceHandler(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        } // DeleteServiceHandler

        public async Task<long> Handle(DeleteServiceCommand command, CancellationToken token)
        {
            var service = await _serviceRepository.GetOne(command.Id, token);

            _serviceRepository.Remove(service);
            await _serviceRepository.SaveChangesAsync(token);

            return command.Id;
        } // Handle
    }
}
