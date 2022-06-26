using Photosite.DAL.Entities.Abstractions;

namespace Photosite.DAL.Entities
{
    public class AboutEntity: IEntity
    {
        public long Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
