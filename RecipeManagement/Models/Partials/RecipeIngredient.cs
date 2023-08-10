using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManagement.Models
{
    public partial class RecipeIngredient : BaseClass
    {

        public override string this[string columnName]
        {
            get
            {
                if (columnName == nameof(RecipeId) && RecipeId < 0)
                {
                    return "Please select a recipe!";
                }

                if (columnName == nameof(IngredientId) && IngredientId < 0)
                {
                    return "Please select a ingredient!";
                }

                if (columnName == nameof(Quantity) && Quantity <= 0)
                {
                    return "Please give a quantity!";
                }

                return "";
            }
        }

    }
}
