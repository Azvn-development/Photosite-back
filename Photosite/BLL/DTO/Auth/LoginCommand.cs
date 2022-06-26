using Photosite.BLL.Models;

namespace Photosite.BLL.DTO.Auth
{
    public class LoginCommand : IBaseCommand<string>
    {
        public UserModel User { get; set; }
    }
}
