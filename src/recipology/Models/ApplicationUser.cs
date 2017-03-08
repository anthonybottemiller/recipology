﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipology.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UsersRecipes> UsersRecipes { get; set; }
    }
}
