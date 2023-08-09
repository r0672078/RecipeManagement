using RecipeManagement.Viewmodels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RecipeManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainViewModel viewModel = new MainViewModel();
            Views.MainView view = new Views.MainView();
            view.DataContext = viewModel;
            view.Show();
        }

    }
}
