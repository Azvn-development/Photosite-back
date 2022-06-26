using Photosite.BLL.DTO.Auth;
using Photosite.DAL.Repositories.User;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using Photosite.Configuration.Options;
using System.Security.Claims;

namespace Photosite.BLL.Handlers.Auth.Handlers
{
    public class LoginHandler: IBaseHandler<LoginCommand, string>
    {
        private readonly IUserRepository _userRepository;
        private readonly AuthOptions _authOptions;

        public LoginHandler(IUserRepository userRepository, IOptions<AuthOptions> authOptions)
        {
            _userRepository = userRepository;
            _authOptions = authOptions.Value;
        } // LoginHandler

        public async Task<string> Handle(LoginCommand command, CancellationToken token)
        {
            var user = await _userRepository.GetOne(command.User.Login, command.User.Password, token);

            if (user == null) return string.Empty;

            // Claim
            var identity = GetClaimsIdentity(command.User.Login);

            // Cоздание JWT-токена
            var jwt = new JwtSecurityToken(
                    issuer: _authOptions.Issurer,
                    audience: _authOptions.Audience,
                    notBefore: DateTime.UtcNow,
                    claims: identity.Claims,
                    signingCredentials: new SigningCredentials(_authOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return encodedJwt;
        } // Handle

        private static ClaimsIdentity GetClaimsIdentity(string login)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, login),
            };

            return new ClaimsIdentity(
                claims,
                "Token",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
        } // GetClaimsIdentity
    }
}
