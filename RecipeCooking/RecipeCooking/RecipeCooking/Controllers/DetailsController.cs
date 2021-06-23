﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeCooking.Controllers
{
    [Route("Details")]
    public class DetailsController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
