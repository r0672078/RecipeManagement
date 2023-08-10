using RecipeManagement.Data.Repositories;
using RecipeManagement.Models;

namespace RecipeManagement.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IRepository<Category> _categoryRepo;
        private IRepository<Chef> _chefRepo;
        private IRepository<Ingredient> _ingredientRepo;
        private IRepository<Recipe> _recipeRepo;
        private IRepository<RecipeCategory> _recipeCategoryRepo;
        private IRepository<RecipeIngredient> _recipeIngredientRepo;
        private RecipeManagingContext Context { get; }

        #region repositories
        public IRepository<Category> CategoryRepo
        {
            get
            {
                if (_categoryRepo == null)
                {
                    _categoryRepo = new Repository<Category>(Context);
                }
                return _categoryRepo;
            }
        }

        public IRepository<Chef> ChefRepo
        {
            get
            {
                if (_chefRepo == null)
                {
                    _chefRepo = new Repository<Chef>(Context);
                }
                return _chefRepo;
            }
        }

        public IRepository<Ingredient> IngredientRepo
        {
            get
            {
                if (_ingredientRepo == null)
                {
                    _ingredientRepo = new Repository<Ingredient>(Context);
                }
                return _ingredientRepo;
            }
        }

        public IRepository<Recipe> RecipeRepo
        {
            get
            {
                if (_recipeRepo == null)
                {
                    _recipeRepo = new Repository<Recipe>(Context);
                }
                return _recipeRepo;
            }
        }

        public IRepository<RecipeCategory> RecipeCategoryRepo
        {
            get
            {
                if (_recipeCategoryRepo == null)
                {
                    _recipeCategoryRepo = new Repository<RecipeCategory>(Context);
                }
                return _recipeCategoryRepo;
            }
        }

        public IRepository<RecipeIngredient> RecipeIngredientRepo
        {
            get
            {
                if (_recipeIngredientRepo == null)
                {
                    _recipeIngredientRepo = new Repository<RecipeIngredient>(Context);
                }
                return _recipeIngredientRepo;
            }
        }       
        #endregion

        public UnitOfWork(RecipeManagingContext ctx)
        {
            Context = ctx;
        }
        public void Dispose()
        {
            Context.Dispose();
        }

        public int Save()
        {
            return Context.SaveChanges();
        }
    }
}
