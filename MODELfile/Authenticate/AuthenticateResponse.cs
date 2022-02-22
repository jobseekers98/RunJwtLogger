using MODELfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MODELfile.Authenticate
{
    public class AuthenticateResponse
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }

        public string RoleName { get; set; }
 



        public AuthenticateResponse(UserModel user, string token,Role role)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.UserName;
            Token = token;
            RoleName = role.RoleName;
        }
    }
}
