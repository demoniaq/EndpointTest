using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace EndpointTestWeb
{
    public class AuthOptions
    {
        public const string ISSUER = "EndPointTestServer";
        public const string AUDIENCE = "EndPointTestClient";
        private const string KEY = "endpointtest_secretkey";
        public const int LIFETIME = 1;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
