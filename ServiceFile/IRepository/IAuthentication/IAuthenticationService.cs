using MODELfile;
using MODELfile.Authenticate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Servicefile.IRepository.IAuthentication
{
    public interface IAuthenticationService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
     
    }
}
