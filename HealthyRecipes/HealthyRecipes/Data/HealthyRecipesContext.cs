using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthyRecipes.Models;

namespace HealthyRecipes.Data
{
    public class HealthyRecipesContext : DbContext
    {
        public HealthyRecipesContext (DbContextOptions<HealthyRecipesContext> options)
            : base(options)
        {
        }

        public DbSet<HealthyRecipes.Models.Recipe> Recipe { get; set; }

        public DbSet<HealthyRecipes.Models.Ingredient> Ingredient { get; set; }

        public DbSet<HealthyRecipes.Models.Chef> Chef { get; set; }
    }
}
