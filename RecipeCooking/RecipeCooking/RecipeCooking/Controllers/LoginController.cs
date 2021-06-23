using CookingApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RecipeCooking.CookingApi.Recipe;
using RecipeCooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeCooking.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("login123")]
        public IActionResult Login(string user, string pass)
        {
            LoginApi loginapi = new LoginApi();
            Task<LoginResponse> response = loginapi.Login(user, pass);
            LoginResponse result = response.Result;
            if (result.message == "NOT FOUND")
            {
                return RedirectToAction("Index");
            } 
            if (result.listRole.Contains("1"))
            {
                return RedirectToAction("Index","Admin");
            }
            
            return RedirectToAction("Index", "");
        }

        [Route("page-register")]
        public IActionResult PageRegister()
        {
           
            return View("Register");
        }


        [Route("register")]
        public IActionResult Register(string user, string password, string fullname, string email, string phone)
        {
            LoginApi loginapi = new LoginApi();
            Task<RegisterResponse> response = loginapi.Register(user, password, fullname, email, phone);
            return RedirectToAction("Index", "Login");
        }
    }
}
