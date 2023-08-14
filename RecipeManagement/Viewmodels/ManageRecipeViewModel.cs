using RecipeManagement.Data;
using RecipeManagement.Data.UnitOfWork;
using RecipeManagement.Models;
using RecipeManagement.Utils;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace RecipeManagement.Viewmodels
{
    public class ManageRecipeViewModel : BaseViewModel, IDisposable
    {

        private IUnitOfWork _unitOfWork = new UnitOfWork(new RecipeManagingContext());
        public override string this[string columnName]
        {
            get { return ""; }
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "Add": Add(); break;
                case "Update": Update(); break;
            }
        }


        private string _error;

        public string ErrorMessage
        {
            get { return _error; }
            set { 
                _error = value;
                NotifyPropertyChanged();
            }
        }


        private string _updateOrAdd;

        public string UpdateOrAdd
        {
            get { return _updateOrAdd; }
            set { 
                _updateOrAdd = value;
                NotifyPropertyChanged();
            }
        }

        private string _updateOrAddButton;

        public string UpdateOrAddButton
        {
            get { return _updateOrAddButton; }
            set { 
                _updateOrAddButton = value;
                NotifyPropertyChanged();
            }
        }

        private ObservableCollection<Recipe> _recipes;

        public ObservableCollection<Recipe> Recipes
        {
            get { return _recipes; }
            set { 
                _recipes = value;
                NotifyPropertyChanged();
            }
        }

        private Recipe _selectedRecipe;

        public Recipe SelectedRecipe
        {
            get { return _selectedRecipe; }
            set { 
                _selectedRecipe = value;
                NotifyPropertyChanged();
            }
        }

        private Recipe _recipe;

        public Recipe Recipe
        {
            get { return _recipe; }
            set { 
                _recipe = value;
                NotifyPropertyChanged();
            }
        }

        public ManageRecipeViewModel()
        {
            Recipe = new Recipe();
            UpdateOrAdd = "Add Recipe";
            UpdateOrAddButton = "Add";
            Recipes = new ObservableCollection<Recipe>(_unitOfWork.RecipeRepo.Retrieve().OrderBy(r => r.Name));
        }

        public ManageRecipeViewModel(Recipe recipe)
        {
            Recipe = recipe;
            UpdateOrAdd = "Update Recipe";
            UpdateOrAddButton = "Update";
            Recipes = new ObservableCollection<Recipe>(_unitOfWork.RecipeRepo.Retrieve().OrderBy(r => r.Name));
            SelectedRecipe = this.Recipe;
        }

        public void Add()
        {
            if (Recipe == null)
            {
                ErrorMessage = "Something went wrong!";
                return;
            }

            if (!Recipe.IsValid())
            {
                ErrorMessage = Recipe.Error;
                return;
            }

            int ok = _unitOfWork.RecipeRepo.Add(Recipe);

            if (ok == 0)
            {
                ErrorMessage = "Adding the recipe has failed!";
                return;
            }

            Recipe = new Recipe();
            SelectedRecipe = null;
            ErrorMessage = "";
            UpdateRecipes();
        }

        public void Update()
        {
            if (Recipe == null)
            {
                ErrorMessage = "Something went wrong!";
                return;
            }

            if (!Recipe.IsValid())
            {
                ErrorMessage = Recipe.Error;
                return;
            }

            int ok = _unitOfWork.RecipeRepo.Update(Recipe);

            if (ok == 0)
            {
                ErrorMessage = "Updating the recipe has failed!";
                return;
            }

            ErrorMessage = "";
            UpdateRecipes();
        }

        public delegate void RecipesUpdateEventHandler(object sender, UpdateGenericListEventArgs<Recipe> e);
        public event RecipesUpdateEventHandler RecipesUpdatedEvent;

        private void UpdateRecipes()
        {
            RecipesUpdatedEvent?.Invoke(this,
                new UpdateGenericListEventArgs<Recipe>(_unitOfWork.RecipeRepo.Retrieve().OrderBy(r => r.Name).ToList()));
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

    }
}
