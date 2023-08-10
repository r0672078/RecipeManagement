using Microsoft.EntityFrameworkCore;
using RecipeManagement.Models;

namespace RecipeManagement.Data
{
    class RecipeManagingContext : DbContext
    {

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<RecipeCategory> RecipeCategories { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Recipes;Trusted_Connection=True;");
        }

    }
}
