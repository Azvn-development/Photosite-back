using AutoMapper;
using Photosite.BLL.Models;
using Photosite.DAL.Entities;

namespace Photosite.BLL.Mapping
{
    public class AboutProfile: Profile
    {
        public AboutProfile()
        {
            CreateMap<AboutModel, AboutEntity>().ReverseMap();
        } // AboutProfile
    }
}
