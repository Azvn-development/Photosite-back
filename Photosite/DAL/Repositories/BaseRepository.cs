using Microsoft.EntityFrameworkCore;
using Photosite.DAL.Entities.Abstractions;

namespace Photosite.DAL.Repositories
{
    public abstract class BaseRepository<TEntity>: IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        protected readonly PhotositeContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(PhotositeContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        } // BaseRepository

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        } // Add

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        } // Update

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        } // Remove

        public Task<bool> IsExist(long id, CancellationToken token)
        {
            return _dbSet.AnyAsync(e => e.Id == id, token);
        } // IsExist

        public Task<int> SaveChangesAsync(CancellationToken token)
        {
            return _context.SaveChangesAsync(token);
        } // SaveChangesAsync
    }
}
