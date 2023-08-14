using RecipeManagement.Data;
using RecipeManagement.Data.UnitOfWork;
using RecipeManagement.Models;
using RecipeManagement.Utils;
using RecipeManagement.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RecipeManagement.Viewmodels
{
    public class RecipeViewModel : BaseViewModel, IDisposable
    {

        private IUnitOfWork _unitOfWork = new UnitOfWork(new RecipeManagingContext());
        public override string this[string columnName] => throw new NotImplementedException();

        public override bool CanExecute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "OpenManageRecipe":
                case "Remove":
                    if (SelectedRecipe == null)
                    {
                        return false;
                    }

                    return true;
                case "OpenAddRecipe": return true;
            }

            return true;
        }
        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "Remove": Remove(); break;
                case "OpenAddRecipe": OpenAddRecipe(); break;
                case "OpenUpdateRecipe": OpenUpdateRecipe(); break;
            }
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { 
                _errorMessage = value;
                NotifyPropertyChanged();
            }
        }

        private string _filter;

        public string Filter
        {
            get { return _filter; }
            set { _filter = value; FilterRecipes(); }
        }

        public List<Recipe> AllRecipes { get; set; }

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

        public RecipeViewModel()
        {
            AllRecipes = _unitOfWork.RecipeRepo.Retrieve(r => r.Name).OrderBy(r => r.Name).ToList();
            Recipes = new ObservableCollection<Recipe>(AllRecipes);
        }

        private void Remove()
        {
            if (SelectedRecipe == null)
            {
                ErrorMessage = "Select a recipe first!";
                return;
            }

            int ok = _unitOfWork.RecipeRepo.Delete(SelectedRecipe);

            if (ok == 0)
            {
                ErrorMessage = "Failed to remove recipe!";
                return;
            }

            AllRecipes = _unitOfWork.RecipeRepo.Retrieve(r => r.Name).OrderBy(r => r.Name).ToList();
            Recipes = new ObservableCollection<Recipe>(AllRecipes);
            SelectedRecipe = null;
        }

        private void OpenAddRecipe()
        {
            ManageRecipeViewModel viewmodel = new ManageRecipeViewModel();
            OpenView(viewmodel);
        }

        private void OpenUpdateRecipe()
        {
            ManageRecipeViewModel viewmodel = new ManageRecipeViewModel(SelectedRecipe);
            OpenView(viewmodel);
        }

        private void OpenView(ManageRecipeViewModel vm)
        {
            ManageRecipeView view = new ManageRecipeView();
            vm.RecipesUpdatedEvent += Viewmodel_RecipesUpdatedEvent;
            view.DataContext = vm;
            view.ShowDialog();

            SelectedRecipe = null;
        }

        private void FilterRecipes()
        {
            Recipes = new ObservableCollection<Recipe>(AllRecipes.Where(r => r.Name.ToLower().Contains(Filter.ToLower())));
        }

        private void Viewmodel_RecipesUpdatedEvent(object sender, UpdateGenericListEventArgs<Recipe> e)
        {
            AllRecipes = e.GenericList;
            Recipes = new ObservableCollection<Recipe>(e.GenericList);
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

    }
}
