using Photosite.DAL.Entities.Abstractions;

namespace Photosite.DAL.Entities
{
    public class UserEntity: IEntity
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
