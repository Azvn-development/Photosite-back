using Photosite.BLL.Models;

namespace Photosite.BLL.DTO.Services
{
    public class CreateServiceCommand: IBaseCommand<CreateServiceResponse>
    {
        public ServiceModel Service { get; set; }
    }

    public class CreateServiceResponse
    {
        public long Id { get; set; }
    }
}
