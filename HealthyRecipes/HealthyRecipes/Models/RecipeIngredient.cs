﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyRecipes.Models
{
    public class RecipeIngredient
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int IngredientQuantity {
            get {
                return IngredientQuantity+1;
            } }

        public int CaloriesPerRecipe { 
            get 
            { return Ingredient.CaloriesPerItem++; } }
        public double ProteinsPerRecipe {
            get
            { return Ingredient.ProteinsPerItem++; }  }
    }
}
