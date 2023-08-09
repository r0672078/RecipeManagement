using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeManagement.Models
{
    public class Ingredient
    {

        public int IngredientId { get; set; }

        [Required]
        public string Name { get; set; }


        // Navigation properties
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }

    }
}
