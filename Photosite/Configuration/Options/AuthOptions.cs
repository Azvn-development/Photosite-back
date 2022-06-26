using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Photosite.Configuration.Options
{
    public class AuthOptions
    {
        public string Issurer { get; set; }
        public string Audience { get; set; }
        public string Key { get; set; }

        public SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
        } // GetSymmetricSecurityKey
    }
}
