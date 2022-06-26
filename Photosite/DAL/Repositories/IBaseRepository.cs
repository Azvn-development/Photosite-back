using Photosite.DAL.Entities.Abstractions;

namespace Photosite.DAL.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        Task<bool> IsExist(long id, CancellationToken token);
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
