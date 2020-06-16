using Microsoft.AspNetCore.Mvc.Rendering;
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
        public int IngredientQuntity { get; set; }
        public int CaloriesPerRecipe { get; set; }
        public int ProteinsPerRecipe { get; set; }
        public SelectList Recipes { get; set; }
        public SelectList Ingredients { get; set; }

        public SelectList IngredientQuntities { get; set; }
        public SelectList  CaloriesPerRecipes { get; set; }
        public SelectList ProteinsPerRecipes { get; set; }

    }
}
