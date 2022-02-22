using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MODELfile;
using MODELfile.Helpers;
using Servicefile.IRepository.IUser;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jwt_Authentication.Controllers
{
    [ApiController]
    [Route("user")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private ILogger<UsersController> _logger;
        public UsersController(IUserService userService, ILogger<UsersController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [Authorize]
        [HttpGet]
        [Route("GetUserDetails")]
        public async Task<List<UserModel>> GetUserDetail(int? userId)
        {
            try
            {
                //int a = 12;
                //int b = 0;
                //int c = a / b;
                return await _userService.GetUserDetail(userId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw ex;
            }


            

        }


        [Authorize]
        [HttpPost]
        [Route("AddUpdateUser")]
        public async Task<int> AddUpdateUser(UserModel user)
        {
            int result = await _userService.AddUpdateUser(user);
            return result;
        }


        [Authorize]
        [HttpDelete]
        [Route("DeleteUser")]
        public async Task<int> DeleteUser(int userId)
        {
            int result = await _userService.DeleteUser(userId);
            return result;
        }
    }
}
