using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Photosite.BLL.DTO.Services;
using Photosite.BLL.Models;
using Photosite.DAL.Repositories.Service;

namespace Photosite.BLL.Handlers.Services.Handlers
{
    public class GetServicesHandler: IBaseHandler<GetServicesQuery, GetServicesResponse>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public GetServicesHandler(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        } // GetServicesHandler

        public async Task<GetServicesResponse> Handle(GetServicesQuery query, CancellationToken token)
        {
            var services = await _serviceRepository
                .GetAll()
                .ToListAsync(token);

            return new GetServicesResponse
            {
                Services = _mapper.Map<List<ServiceModel>>(services)
            };
        } // Handle
    }
}
