using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace RecipeManagement.Viewmodels
{
    public abstract class BaseViewModel : IDataErrorInfo, INotifyPropertyChanged, ICommand
    {
        
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public abstract string this[string columnName] { get; }

        public bool IsValid()
        {
            return string.IsNullOrWhiteSpace(Error);
        }

        public string Error
        {
            get
            {
                string errorMessages = "";

                foreach (var item in this.GetType().GetProperties())
                {
                    if (item.CanRead)
                    {
                        string error = this[item.Name];
                        if (!string.IsNullOrWhiteSpace(error))
                        {
                            errorMessages += error + Environment.NewLine;
                        }
                    }
                }
                return errorMessages;
            }
        }
    }
}
