using RecipeManagement.Data.Repositories;
using RecipeManagement.Models;
using System;

namespace RecipeManagement.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Category> CategoryRepo { get; }
        IRepository<Chef> ChefRepo { get; }
        IRepository<Ingredient> IngredientRepo { get; }
        IRepository<Recipe> RecipeRepo { get; }
        IRepository<RecipeCategory> RecipeCategoryRepo { get; }
        IRepository<RecipeIngredient> RecipeIngredientRepo { get; }

        int Save();
    }
}
