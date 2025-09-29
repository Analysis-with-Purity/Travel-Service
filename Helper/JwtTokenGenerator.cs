using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Travel_Service.Models.Entity;

namespace Travel_Service.Helper
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
public class JwtTokenGenerator: IJwtTokenGenerator
{

        private readonly IConfiguration _config;

        public JwtTokenGenerator(IConfiguration config)
        {
            _config = config;
        }

        public string GenerateToken(string firstName)
        {

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, firstName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };


            var keysecret = _config["Appsettings:secret"];
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keysecret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            var expiration = DateTime.UtcNow.AddDays(1);


            var tokenDescriptor = new JwtSecurityToken(
                issuer: _config["Appsettings:ValidIssuer"],
                audience: _config["Appsettings:ValidAudience"],
                expires: expiration,
                signingCredentials: credentials,
                claims: claims
            );

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(tokenDescriptor);


        }

        public string GenerateToken(User user)
        {
            throw new NotImplementedException();
        }
}
}



