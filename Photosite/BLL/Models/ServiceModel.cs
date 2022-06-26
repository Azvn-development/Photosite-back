using Photosite.Common.Enums;

namespace Photosite.BLL.Models
{
    public class ServiceModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ServiceType Type { get; set; }
    }
}
