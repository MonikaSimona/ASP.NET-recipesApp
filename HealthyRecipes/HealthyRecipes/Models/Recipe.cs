using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyRecipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Title { get; set; }
        [StringLength(300)]
        [Required]
        public string Description { get; set; }
        [DataType(DataType.Time)]
        [Required]
        public TimeSpan PrepareTime { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public int ChefId { get; set; }
        public Chef Chef { get; set; }
        public ICollection<RecipeIngredient> Ingredients { get; set; }
    }
}
