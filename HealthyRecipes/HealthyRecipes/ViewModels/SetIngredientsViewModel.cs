﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyRecipes.ViewModels
{
    public class SetIngredientsViewModel
    {
        public int RecipeId { get; set; }
        public IList<int> IngredientIds { get; set; }
     
        public SelectList Recipes { get; set; }
        public SelectList Ingredients { get; set; }

     

    }
}
