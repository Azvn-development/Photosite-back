using Photosite.BLL.Models;

namespace Photosite.BLL.DTO.Abouts
{
    public class CreateAboutCommand : IBaseCommand<long>
    {
        public AboutModel About { get; set; }
    }
}
