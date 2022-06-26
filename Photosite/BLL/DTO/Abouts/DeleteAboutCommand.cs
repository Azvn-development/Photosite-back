using Microsoft.AspNetCore.Mvc;

namespace Photosite.BLL.DTO.Abouts
{
    public class DeleteAboutCommand: IBaseCommand<long>
    {
        [FromQuery(Name = "id")]
        public long Id { get; set; }
    }
}
