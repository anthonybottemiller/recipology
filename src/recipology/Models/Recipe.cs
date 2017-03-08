using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recipology.Models
{
    [Table("Recipes")]
    public class Recipe
    {
        public Recipe()
        {
            TimesForked = 0;
        }

        [Key]
        public int RecipeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Ingredients { get; set; }

        public string Author { get; set; }

        public int TimesForked { get; set; }

        public ICollection<UsersRecipes> UsersRecipes { get; set;}

        public ICollection<Recipe> RecipeHistory { get; set; }

        public void AddVersion(Recipe recipe)
        {
            this.RecipeHistory.Add(recipe);
            var db = new RecipologyDbContext();
            db.Entry(this).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
