using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MODELfile;
using MODELfile.Authenticate;
using Servicefile.IRepository.IAuthentication;
using Servicefile.IRepository.IUser;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;                                                                     




namespace Jwt_Authentication.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticationService _IauthenticationService;
        public AuthenticationController(IAuthenticationService IauthenticationService)
        {
            _IauthenticationService = IauthenticationService;
        }

        [HttpPost]                                  
        [Route("login")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
          
            var response = _IauthenticationService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
            //if (response.RoleName == "User")
            //{
            //    //return Ok(response);
            //    return RedirectToAction("DashBoard");
            //}
            //else if(response.RoleName == "Admin")
            //{
            //    return RedirectToAction("Users");
            //}
            //else 
            //{
            //    return BadRequest(new { message = "Username or password is incorrect" });
            //}


        }

    }
}
