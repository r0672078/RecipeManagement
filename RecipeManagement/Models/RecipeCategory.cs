using System.ComponentModel.DataAnnotations;

namespace RecipeManagement.Models
{
    public partial class RecipeCategory
    {

        public int RecipeCategoryId { get; set; }

        [Required]
        public int RecipeId { get; set; }

        [Required]
        public int CategoryId { get; set; }


        // Navigation properties
        public Recipe Recipe { get; set; }
        public Category Category { get; set; }

    }
}
