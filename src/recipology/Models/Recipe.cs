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
        [Key]
        public int RecipeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Ingredients { get; set; }

        public ICollection<UsersRecipes> UsersRecipes { get; set;}
    }
}
