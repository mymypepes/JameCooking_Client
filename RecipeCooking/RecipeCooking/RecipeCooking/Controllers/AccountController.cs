using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeCooking.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View("index");
        }
    }
}
