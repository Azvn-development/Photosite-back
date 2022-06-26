using Photosite.BLL.Models;

namespace Photosite.BLL.DTO.Abouts
{
    public class CreateAboutCommand : IBaseCommand<CreateAboutResponse>
    {
        public AboutModel About { get; set; }
    }

    public class CreateAboutResponse
    {
        public long Id { get; set; }
    }
}
