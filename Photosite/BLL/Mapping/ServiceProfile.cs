using AutoMapper;
using Photosite.BLL.Models;
using Photosite.DAL.Entities;

namespace Photosite.BLL.Mapping
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<ServiceModel, ServiceEntity>().ReverseMap();
        } // ServiceProfile
    }
}
