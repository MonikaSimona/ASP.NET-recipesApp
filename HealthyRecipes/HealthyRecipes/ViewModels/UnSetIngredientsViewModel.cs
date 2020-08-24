using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyRecipes.ViewModels
{
    public class UnSetIngredientsViewModel
    {
        [Display(Name = "Recipe")]
        public int RecipeId { get; set; }

        public IList<int> RecipeIngredientIds { get; set; }
        public SelectList RecipeIngredients { get; set; }
        public SelectList Recipes { get; set; }
        public SelectList Ingredients { get; set; }
    }
}
