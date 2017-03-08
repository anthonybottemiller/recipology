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
            return View(db.Recipes.ToList());
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
