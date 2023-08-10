namespace RecipeManagement.Models
{
    public partial class Chef : BaseClass
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
