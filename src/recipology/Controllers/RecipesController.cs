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
            ApplicationUser user = db.ApplicationUsers.FirstOrDefault(users => users.UserName == User.Identity.Name);
            recipe.Author = User.Identity.Name;
            db.Recipes.Add(recipe);
            db.SaveChanges();
            user.AddRecipe(recipe.RecipeId);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Detail(int id)
        {
            var recipe = db.Recipes.Find(id);
            return View(recipe);
        }
    }
}
