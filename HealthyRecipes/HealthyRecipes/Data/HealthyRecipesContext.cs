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
        public DbSet<RecipeIngredient> RecipeIngredient { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RecipeIngredient>()
                .HasOne<Recipe>(p => p.Recipe)
                .WithMany(p => p.Ingredients)
                .HasForeignKey(p => p.RecipeId);

            builder.Entity<RecipeIngredient>()
                .HasOne<Ingredient>(p => p.Ingredient)
                .WithMany(p => p.Recipes)
                .HasForeignKey(p => p.IngredientId);

            builder.Entity<Recipe>()
                .HasOne<Chef>(p => p.Chef)
                .WithMany(p => p.Recipes)
                .HasForeignKey(p => p.ChefId);
        }
    }
}
