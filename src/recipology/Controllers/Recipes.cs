using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipology.Models;

namespace recipology.Controllers
{
    public class Recipes : Controller
    {
        private RecipologyDbContext db = new RecipologyDbContext();

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Recipe recipe)
        {
            db.Recipes.Add(recipe);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
