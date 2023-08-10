namespace RecipeManagement.Models
{
    public partial class Recipe : BaseClass
    {

        public override string this[string columnName]
        {
            get
            {
                if (columnName == nameof(ChefId) && ChefId < 0)
                {
                    return "Please select a chef!";
                }

                if (columnName == nameof(Name) && string.IsNullOrWhiteSpace(Name))
                {
                    return "Enter a name!";
                }
                              
                if (columnName == nameof(Instructions) && string.IsNullOrWhiteSpace(Instructions))
                {
                    return "Enter the recipe instructions!";
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
