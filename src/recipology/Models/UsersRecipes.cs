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
        public UsersRecipes()
        {

        }
        public UsersRecipes(string userName, int recipeId)
        {
            this.RecipeId = recipeId;
            this.UserName = userName;
        }

        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public int RecipeId { get; set; }
    }
}
