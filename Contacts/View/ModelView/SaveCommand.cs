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
    /// Хранит команду сохранения.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Ссылка на экземпляр MainVM.
        /// </summary>
        private MainVM MainVM { get; }

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
            ContactSerializer.Serialize(MainVM.CurentContact);
        }
        /// <summary>
        /// Срабатывет, если CanExecute изменил значение (это никогда не произойдёт).
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Создаёт объект класса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="mainVM">Ссылка на экземпляр MainVM..</param>
        public SaveCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }
    }
}
