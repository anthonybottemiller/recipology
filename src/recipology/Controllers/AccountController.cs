using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipology.Models;
using Microsoft.AspNetCore.Identity;
using Recipology.ViewModels;


namespace recipology.Controllers
{
    public class AccountController : Controller
    {
        private RecipologyDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RecipologyDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var user = new ApplicationUser { UserName = model.UserName };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult KeepRecipe(int id)
        {
            ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(users => users.UserName == User.Identity.Name);
            Recipe recipe = _db.Recipes.FirstOrDefault(recipes => recipes.RecipeId == id);
            user.AddRecipe(recipe.RecipeId);
            return Json(recipe);
        }

        public IActionResult MyCookbook()
        {
            var cookbook = from r in _db.Recipes
                              join jt in _db.UsersRecipes on r.RecipeId equals jt.RecipeId
                              join usr in _db.Users on jt.UserName equals usr.UserName
                              where usr.UserName == User.Identity.Name
                              select r;

            return View(cookbook);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Top", "Recipes");
        }
    }
}
