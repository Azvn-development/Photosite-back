namespace Photosite.BLL.DTO.Services
{
    public class DeleteServiceCommand: IBaseCommand<long>
    {
        public long Id { get; set; }
    }
}
