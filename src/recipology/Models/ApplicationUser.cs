using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipology.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UsersRecipes> UsersRecipes { get; set; }

        public void AddRecipe(int _RecipeId)
        {
            var db = new RecipologyDbContext();
            var newRecipe = db.Recipes.FirstOrDefault(recipes => recipes.RecipeId == _RecipeId);
            var NewJoinEntry = new UsersRecipes(this.Id, newRecipe.RecipeId);
            db.UsersRecipes.Add(NewJoinEntry);
            db.SaveChanges();
        }
    }
}
