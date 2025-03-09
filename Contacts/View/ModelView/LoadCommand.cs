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
    /// <summary>
    /// Хранит команду загрузки.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Хранит исполняемый делегат.
        /// </summary>
        private Action<object> execute;

        /// <summary>
        /// Проверяет, может ли команда сработать.
        /// </summary>
        /// <param name="parameter">Принимаемый делегат.</param>
        /// <returns>true, всегда.</returns>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет фунцию в делегате.
        /// </summary>
        /// <param name="parameter">Принимаемый делегат.</param>
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
        /// <summary>
        /// Срабатывет, если CanExecute изменил значение (это никогда не произойдёт).
        /// </summary>
        public event EventHandler CanExecuteChanged { add { } remove { } }

        /// <summary>
        /// Создаёт объект класса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="execute">Принимаемый делегат.</param>
        public LoadCommand(Action<object> execute)
        {
            this.execute = execute;
        }
    }
}
