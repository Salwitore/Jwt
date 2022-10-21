using Data.EntityClasses;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Utils.Helpers;
using Utils.Auth;
using DataAccess;

namespace Utils.JWT
{
    public class JWTFactory
    {
        //Token üretme Token Describe etme metodlar

        /* App settings class’ı appsettings.json dosyasında tanımlanan özellikleri içerir
         * ve dependency injection ile yerleşik olarak ASP.NET Core projelerinde kullanılarak
         * sınıflara enjekte edilen nesneler üzerinden uygulama ayarlarına erişmek için kullanılır. */


        private readonly AppSettings _appSettings;

        public JWTFactory(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public User Authenticate(LoginUser loginUser)
        {
            var masterDataAccess = new MasterDataAccess();

            var user = masterDataAccess.GetUsers().SingleOrDefault(u => u.UserId.Equals(loginUser.UserId));

            if (user == null)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name,user.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user;
        }

    }
}
