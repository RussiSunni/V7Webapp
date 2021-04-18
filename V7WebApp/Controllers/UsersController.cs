using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using V7WebApp.Models;
using V7WebApp.Services;

namespace V7WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        public UsersController(JsonFileUserService userService)
        {
            this.UserService = userService;
        }

        public JsonFileUserService UserService { get; }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return UserService.GetUsers();
        }
    }
}
