using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
namespace Jwt_Authentication.Controllers
{
    //[Route("api/[controller]")]
    [Route("DashBoard")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {

        [Route("GetAll")]
        [HttpPost]
        public IActionResult GetAll()
        {

            return Ok();
        
        }






    }
}
