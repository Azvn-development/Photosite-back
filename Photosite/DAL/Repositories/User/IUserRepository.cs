using Photosite.DAL.Entities;

namespace Photosite.DAL.Repositories.User
{
    public interface IUserRepository: IBaseRepository<UserEntity>
    {
        Task<UserEntity> GetOne(string login, string password, CancellationToken token);
    }
}
