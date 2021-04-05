using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using V7WebApp.Services;
using V7WebApp.Models;

namespace V7WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileUserService UserService;
        public IEnumerable<User> Users { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileUserService userService)
        {
            _logger = logger;
            UserService = userService;
        }

        public void OnGet()
        {
            Users = UserService.GetUsers();
        }
    }
}
