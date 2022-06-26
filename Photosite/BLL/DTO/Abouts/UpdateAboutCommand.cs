using Photosite.BLL.Models;

namespace Photosite.BLL.DTO.Abouts
{
    public class UpdateAboutCommand: IBaseCommand<UpdateAboutResponse>
    {
        public AboutModel About { get; set; }
    }

    public class UpdateAboutResponse
    {
        public long Id { get; set; }
    }
}
