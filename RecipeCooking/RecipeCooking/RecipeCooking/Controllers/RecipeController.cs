using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Http.Json;
using RecipeCooking.CookingApi.Recipe;

namespace RecipeCooking.Controllers
{
    //[Route("Recipe")]
    public class RecipeController : Controller
    {
        //private RecipeApi recipe;
        //public RecipeController(RecipeApi _recipe)
        //{
        //    recipe = _recipe;
        //}
        //[Route("")]
        public IActionResult Index()
        {
            
            //var response = recipe.FindAll().Result;
            //if (response.IsSuccessStatusCode)
            //{
            //    var result = response.Content.ReadAsStringAsync().Result;
            //    //var recipes = JsonContent.DeserializeObject<List<Recipe>>(result);
            //    ViewBag.recipe = recipes;
            //}
            return View();
        }
    }
}
