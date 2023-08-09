using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeManagement.Models
{
    public class Chef
    {

        public int ChefId { get; set; }

        [Required]
        public string Name { get; set; }


        // Navigation properties
        public ICollection<Recipe> Recipes { get; set; }

    }
}
