using DALfile;
using DALfile.IRepository;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MODELfile;
using MODELfile.Authenticate;
using MODELfile.Helpers;
using Servicefile.IRepository.IAuthentication;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Servicefile.Repository.Authentication
{
    public class AuthenticationService: IAuthenticationService
    {
        private readonly AppSettings _appSettings;
        private readonly IAuthenticationDal _IauthenticationDal;
        public AuthenticationService(IOptions<AppSettings> appSettings, IAuthenticationDal IauthenticationDal)
        {
            _appSettings = appSettings.Value;
            _IauthenticationDal = IauthenticationDal;
        }
        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            return  _IauthenticationDal.Authenticate(model);
            



        }

      

       

    }
}
