using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyRecipes.Models
{
    public class Chef
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]

        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]

        public string LastName { get; set; }
        public string ImageUrl { get; set; }

        public string FullName
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
