using Microsoft.EntityFrameworkCore;
using RecipeManagement.Data;
using RecipeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reisplanningssysteem_DAL
{
    public class DatabaseOperations
    {
        public static List<Recipe> GetRecipesList()
        {
            using (RecipeManagingContext ctx = new RecipeManagingContext())
            {
                return ctx.Recipes.
                    Include(r => r.Name).
                    Include(r=> r.ChefId).
                    Include(r => r.PreparationTime).
                    Include(r => r.CookingTime).
                    Include(r => r.Servings).
                    Include(r => r.Origin).
                    Include(r => r.Instructions).
                    OrderBy(r => r.Name).
                    ToList();
            }
        }

        public static List<Recipe> GetRecipesFilteredList(string input)
        {
            using (RecipeManagingContext ctx = new RecipeManagingContext())
            {
                return ctx.Recipes
                    .Where(r => r.ToString().Contains(input))
                    .Include(r => r.Name).ToList();
            }
        }

        public static Recipe SearchRecipeOnId(int recipeId)
        {
            using (RecipeManagingContext ctx = new RecipeManagingContext())
            {
                return ctx.Recipes
                    .Where(r => r.RecipeId == recipeId).First();
            }
        }

        public static int RemoveRecipe(Recipe recipe)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Entry(recipe).State = EntityState.Deleted;
                    return ctx.SaveChanges();
                }                    
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int AddRecipe(Recipe recipe)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Recipes.Add(recipe);
                    return ctx.SaveChanges();
                }                    
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int UpdateRecipe(Recipe recipe)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Entry(recipe).State = EntityState.Modified;
                    return ctx.SaveChanges();
                }                    
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static List<Category> GetCategories()
        {
            using (RecipeManagingContext ctx = new RecipeManagingContext())
            {
                return ctx.Categories.OrderBy(g => g.Name).ToList();
            }
        }              

        public static int RemoveCategory(Category selectedCategory)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Entry(selectedCategory).State = EntityState.Deleted;
                    return ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int UpdateCategory(Category category)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Entry(category).State = EntityState.Modified;
                    return ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int AddCategory(Category category)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Entry(category).State = EntityState.Added;
                    return ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static List<Chef> GetChefs()
        {
            using (RecipeManagingContext ctx = new RecipeManagingContext())
            {
                return ctx.Chefs.OrderBy(g => g.Name).ToList();
            }
        }

        public static int RemoveChef(Chef selectedChef)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Entry(selectedChef).State = EntityState.Deleted;
                    return ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int UpdateChef(Chef chef)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Entry(chef).State = EntityState.Modified;
                    return ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int AddChef(Chef chef)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Entry(chef).State = EntityState.Added;
                    return ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static List<Ingredient> GetIngredients()
        {
            using (RecipeManagingContext ctx = new RecipeManagingContext())
            {
                return ctx.Ingredients.OrderBy(g => g.Name).ToList();
            }
        }

        public static int RemoveIngredient(Ingredient selectedIngredient)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Entry(selectedIngredient).State = EntityState.Deleted;
                    return ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int UpdateIngredient(Ingredient ingredient)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Entry(ingredient).State = EntityState.Modified;
                    return ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int AddIngredient(Ingredient ingredient)
        {
            try
            {
                using (RecipeManagingContext ctx = new RecipeManagingContext())
                {
                    ctx.Entry(ingredient).State = EntityState.Added;
                    return ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }             

        public static RecipeCategory GetRecipeCategory(Recipe recipe, Category category)
        {
            using (RecipeManagingContext ctx = new RecipeManagingContext())
            {
                return ctx.RecipeCategories .Where(x => x.Recipe == recipe && x.Category == category).First();
            }
        }

        public static RecipeIngredient GetRecipeIngredient(Recipe recipe, Ingredient ingredient)
        {
            using (RecipeManagingContext ctx = new RecipeManagingContext())
            {
                return ctx.RecipeIngredients.Where(x => x.Recipe == recipe && x.Ingredient == ingredient).First();
            }
        }
    }
}
