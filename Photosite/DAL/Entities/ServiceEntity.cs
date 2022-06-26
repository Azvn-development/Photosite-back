using Photosite.Common.Enums;
using Photosite.DAL.Entities.Abstractions;

namespace Photosite.DAL.Entities
{
    public class ServiceEntity: IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ServiceType Type { get; set; }
    }
}
