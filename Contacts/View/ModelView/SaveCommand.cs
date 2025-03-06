using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ModelView
{
    public class SaveCommand : ICommand
    {
        private Action<object> execute;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }

        public SaveCommand(Action<object> execute)
        {
            this.execute = execute;
        }
    }
}
