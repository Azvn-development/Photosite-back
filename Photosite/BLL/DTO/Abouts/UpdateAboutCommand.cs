using Photosite.BLL.Models;

namespace Photosite.BLL.DTO.Abouts
{
    public class UpdateAboutCommand: IBaseCommand<long>
    {
        public AboutModel About { get; set; }
    }
}
