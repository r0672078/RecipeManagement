using System;
using System.Collections.Generic;

namespace RecipeManagement.Utils
{
    public class UpdateGenericListEventArgs<T> : EventArgs
    {
        public List<T> GenericList { get; set; }
        public UpdateGenericListEventArgs(List<T> genericList)
        {
            GenericList = genericList;
        }
    }
}
