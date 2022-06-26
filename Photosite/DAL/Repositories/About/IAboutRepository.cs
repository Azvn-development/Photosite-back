using Photosite.DAL.Entities;

namespace Photosite.DAL.Repositories.About
{
    public interface IAboutRepository: IBaseRepository<AboutEntity>
    {
        IQueryable<AboutEntity> GetAll();
        Task<AboutEntity> GetOne(long id, CancellationToken token);
    }
}
