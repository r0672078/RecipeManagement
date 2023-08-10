namespace RecipeManagement.Models
{
    public partial class RecipeCategory : BaseClass
    {

        public override string this[string columnName]
        {
            get
            {
                if (columnName == nameof(RecipeId) && RecipeId < 0)
                {
                    return "Please select a recipe!";
                }

                if (columnName == nameof(CategoryId) && CategoryId < 0)
                {
                    return "Please select a category!";
                }

                return "";
            }
        }
    }
}
