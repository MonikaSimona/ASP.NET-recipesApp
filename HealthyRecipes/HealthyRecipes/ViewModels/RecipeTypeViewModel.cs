using HealthyRecipes.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyRecipes.ViewModels
{
    public class RecipeTypeViewModel
    {
        public IList<Recipe> Recipes { get; set; }
        public SelectList Types { get; set; }
        public string RecipeType { get; set; }
        public string SearchString { get; set; }


    }
}
