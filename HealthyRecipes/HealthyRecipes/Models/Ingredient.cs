using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyRecipes.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int CaloriesPerItem { get; set; }
        [Required]
        public int ProteinsPerItem { get; set; }
        public int VitaminsPerItem { get; set; }
        [StringLength(300)]
        public string IngredientFact { get; set; }
        public ICollection<RecipeIngredient> Recipes { get; set; }

    }
}
