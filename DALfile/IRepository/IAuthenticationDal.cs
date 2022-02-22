using MODELfile;
using MODELfile.Authenticate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DALfile.IRepository
{
    public interface IAuthenticationDal
    {
         AuthenticateResponse Authenticate(AuthenticateRequest model);
          public string GenerateToken(UserModel user);
    }
}
