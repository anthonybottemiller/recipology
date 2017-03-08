using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recipology.Models
{
    [Table("UsersRecipes")]
    public class UsersRecipes
    {
        public UsersRecipes(string userId, int recipeId)
        {
            this.RecipeId = recipeId;
            this.UserId = userId;
        }

        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public int RecipeId { get; set; }
    }
}
