using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeCooking.Controllers
{
    [Route("Contest")]
    public class ContestController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
