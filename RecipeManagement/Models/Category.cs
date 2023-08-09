using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeManagement.Models
{
    public class Category
    {

        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }


        // Navigation properties
        public ICollection<RecipeCategory> RecipeCategories { get; set; }

    }
}
