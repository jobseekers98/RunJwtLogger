using DALfile.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MODELfile;
using MODELfile.Authenticate;
using MODELfile.Helpers;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DALfile.Repository
{
    public class AuthenticationDal : IAuthenticationDal
    {
        public readonly ApplicationContext _dbcontext =null;
        private readonly AppSettings _appSettings;
        public AuthenticationDal(ApplicationContext dbcontext, IOptions<AppSettings> appSettings)
        {
            _dbcontext = dbcontext;
            _appSettings = appSettings.Value;


        }

        public   AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
         
            var response = _dbcontext.Users.FirstOrDefault(x => x.UserName == model.Username && x.Password == model.Password);
            var userRole = _dbcontext.UserRoles.Where(x => x.UID == response.Id).FirstOrDefault();
            var rolemodel = _dbcontext.Roles.Where(x => x.RoleID == userRole.RoleID).FirstOrDefault();



            if (response == null) return null;
            Role role=new Role();
            //If authentication is successful
            var token = GenerateToken(response);
            return new AuthenticateResponse(response, token, rolemodel);

        }

        public string GenerateToken(UserModel user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


    }
}
