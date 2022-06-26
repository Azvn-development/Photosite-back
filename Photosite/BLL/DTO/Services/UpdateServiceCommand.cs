using Photosite.BLL.Models;

namespace Photosite.BLL.DTO.Services
{
    public class UpdateServiceCommand: IBaseCommand<UpdateServiceResponse>
    {
        public ServiceModel Service { get; set; }
    }

    public class UpdateServiceResponse
    {
        public long Id { get; set; }
    }
}
