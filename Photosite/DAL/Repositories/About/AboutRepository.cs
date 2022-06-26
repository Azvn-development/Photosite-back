using Microsoft.EntityFrameworkCore;
using Photosite.DAL.Entities;

namespace Photosite.DAL.Repositories.About
{
    public class AboutRepository: BaseRepository<AboutEntity>, IAboutRepository
    {
        public AboutRepository(PhotositeContext photositeContext): base(photositeContext) { }

        public IQueryable<AboutEntity> GetAll()
        {
            return _dbSet;
        } // GetAll

        public Task<AboutEntity> GetOne(long id, CancellationToken token)
        {
            return _dbSet.FirstOrDefaultAsync(x => x.Id == id, token);
        } // GetOne
    }
}
