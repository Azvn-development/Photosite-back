using Microsoft.EntityFrameworkCore;
using Photosite.DAL.Entities;

namespace Photosite.DAL.Repositories.User
{
    public class UserRepository: BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(PhotositeContext photositeContext): base(photositeContext) { }

        public Task<UserEntity> GetOne(string login, string password, CancellationToken token)
        {
            return _dbSet.FirstOrDefaultAsync(x => x.Login == login && x.Password == password, token);
        } // GetOne
    }
}
