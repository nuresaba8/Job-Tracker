using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Job_Tracker.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(UserDTO obj)
        {
            var data = UserService.Login(obj);
            return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Successfully Logged in!", Role = data });
        }
    }
}
