using SalesCRMApp.Models;
//using SalesCRMApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SalesCRMApp.Controllers
{
    public class TestController : Controller
    {
        //private readonly UserManager<ApplicationUser> _userManager;
        private readonly UserManager<IdentityUser> _userManager;

        public TestController(UserManager<IdentityUser> userManager)
        //public TestController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            //List all the users created by the user
            var users = _userManager.Users;
            return View(users);
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(IdentityUser model)
        {
            // avoid duplicate role
            //if (!_userManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
            //{
            //    _userManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
            //}
            return RedirectToAction("Index");
        }


    }
}

