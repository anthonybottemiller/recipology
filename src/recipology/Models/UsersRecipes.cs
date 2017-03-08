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
        [Key]
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public Recipe Recipe { get; set; }
    }
}
