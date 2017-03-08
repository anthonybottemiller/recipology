using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipology.Models;
using Microsoft.AspNetCore.Authorization;

namespace recipology.Controllers
{
    public class RecipesController : Controller
    {
        private RecipologyDbContext db = new RecipologyDbContext();

        public IActionResult Top()
        {
            var topRecipes = from r in db.Recipes
                             orderby r.TimesForked descending
                             select r;
            return View(topRecipes);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Recipe recipe)
        {
            db.Recipes.Add(recipe);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
