using RecipeManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RecipeManagement.Viewmodels
{
    public class MainViewModel : BaseViewModel
    {

        public override string this[string columnName] => throw new NotImplementedException();

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "OpenRecipes": OpenRecipeView(); break;
                case "OpenManageRecipes": OpenManageRecipeView(); break;
            }
        }

        private void OpenRecipeView()
        {
            var viewmodel = new RecipeViewModel();
            var view = new RecipeView();
            OpenView(ref viewmodel, view);
        }

        private void OpenManageRecipeView()
        {
            var viewmodel = new ManageRecipeViewModel();
            var view = new ManageRecipeView();
            OpenView(ref viewmodel, view);
        }

        private void OpenView<T>(ref T viewmodel, Window view)
        {
            view.DataContext = viewmodel;
            view.ShowDialog();
        }

    }
}
