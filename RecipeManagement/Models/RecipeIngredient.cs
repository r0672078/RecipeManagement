using System.ComponentModel.DataAnnotations;

namespace RecipeManagement.Models
{
    public class RecipeIngredient
    {

        public int RecipeIngredientId { get; set; }

        [Required]
        public int RecipeId { get; set; }

        [Required]
        public int IngredientId { get; set; }

        [Required]
        public decimal Quantity { get; set; }


        // Navigation properties
        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }

    }
}
