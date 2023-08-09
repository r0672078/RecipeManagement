using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeManagement.Models
{
    public class Recipe
    {

        public int RecipeId { get; set; }

        [Required]
        public int ChefId { get; set; }

        [Required]
        public string Name { get; set; }

        public string PreparationTime { get; set; }

        public string CookingTime { get; set; }

        public int Servings { get; set; }

        public string Origin { get; set; }

        [Required]
        public string Instructions { get; set; }


        // Navigation properties
        public Chef Chef { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        public ICollection<RecipeCategory> RecipeCategories { get; set; }

    }
}
