using Photosite.DAL.Entities;

namespace Photosite.DAL.Repositories.Service
{
    public interface IServiceRepository: IBaseRepository<ServiceEntity>
    {
        IQueryable<ServiceEntity> GetAll();
        Task<ServiceEntity> GetOne(long id, CancellationToken token);
    }
}
