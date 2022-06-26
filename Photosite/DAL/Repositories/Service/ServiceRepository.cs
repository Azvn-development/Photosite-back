using Microsoft.EntityFrameworkCore;
using Photosite.DAL.Entities;

namespace Photosite.DAL.Repositories.Service
{
    public class ServiceRepository: BaseRepository<ServiceEntity>, IServiceRepository
    {
        public ServiceRepository(PhotositeContext context): base(context) { }

        public IQueryable<ServiceEntity> GetAll()
        {
            return _dbSet;
        } // GetAll

        public Task<ServiceEntity> GetOne(long id, CancellationToken token)
        {
            return _dbSet.FirstOrDefaultAsync(x => x.Id == id, token);
        } // GetOne
    }
}
