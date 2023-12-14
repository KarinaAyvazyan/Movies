using Microsoft.AspNetCore.Mvc;
using Movies.Services.Interfaces;
using Movies.ViewModels.Users;
using Movies.Services;
using Movies.ViewModels.Films;
using System;
using Movies.ViewModels;
using Movies.Data.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

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
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
         
            if (_userService.Login(model))
            {
       
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Something is wrong ! ";
            }
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
        {       if(ModelState.IsValid)
            if(model.Id==0)
            {
                _userService.Add(model);

         
                {
                    return RedirectToAction("Index","Home");
                }
                
            }
         return View( model);  

     

      

        }
        }
    }
