using Photosite.BLL.Models;

namespace Photosite.BLL.DTO.Services
{
    public class GetServicesQuery: IBaseQuery<GetServicesResponse> {}

    public class GetServicesResponse
    {
        public List<ServiceModel> Services { get; set; }
    }
}
