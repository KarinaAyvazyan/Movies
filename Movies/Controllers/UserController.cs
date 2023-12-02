using Microsoft.AspNetCore.Mvc;
using Movies.Services.Interfaces;
using Movies.ViewModels.Users;
using Movies.Services;
using Movies.ViewModels.Films;

namespace Movies.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register( int? id)
        {
            UserViewModel model = id.HasValue ? _userService.GetById(id.Value) : new UserViewModel();
            return View(model);
          
        }
        [HttpPost]
        public IActionResult Register(UserViewModel model)
        {
            {

                if (model.Id > 0)
                {
                    _userService.Update(model);
                    return View(model);
                }
                else
                {
                    _userService.Add(model);
                }
                return RedirectToAction("Index","Home");
            }
        }
    }
}
