using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
        }

    }
}
