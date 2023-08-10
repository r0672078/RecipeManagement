using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManagement.Models
{
    public partial class Ingredient : BaseClass
    {

        public override string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Name) && string.IsNullOrWhiteSpace(Name))
                {
                    return "Enter a name!";
                }

                return "";
            }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
