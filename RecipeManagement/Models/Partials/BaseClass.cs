using System;
using System.ComponentModel;

namespace RecipeManagement.Models
{
    public abstract class BaseClass : IDataErrorInfo
    {

        public abstract string this[string columnName] { get; }

        public bool IsValid()
        {
            return string.IsNullOrWhiteSpace(Error);
        }

        public string Error
        {
            get
            {
                string foutmeldingen = "";

                foreach (var item in GetType().GetProperties()) //reflection
                {
                    string fout = this[item.Name];
                    if (!string.IsNullOrWhiteSpace(fout))
                    {
                        foutmeldingen += fout + Environment.NewLine;
                    }
                }
                return foutmeldingen;
            }
        }

    }
}
