using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using View.Model.Services;

namespace View.ModelView.Commands
{
    /// <summary>
    /// Хранит команду добавления.
    /// </summary>
    public class AddCommand : ICommand
    {
        /// <summary>
        /// Ссылка на экземпляр MainVM.
        /// </summary>
        private MainVM MainVM { get; }

        /// <summary>
        /// Проверяет, может ли команда сработать.
        /// </summary>
        /// <param name="parameter">Принимаемый параметр.</param>
        /// <returns>true, всегда.</returns>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет фунцию в делегате.
        /// </summary>
        /// <param name="parameter">Принимаемый параметр.</param>
        public void Execute(object parameter)
        {
            MessageBox.Show("Add");
        }
        /// <summary>
        /// Срабатывет, если CanExecute изменил значение (это никогда не произойдёт).
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Создаёт объект класса <see cref="LoadCommand"/>.
        /// </summary>
        /// <param name="mainVM">Ссылка на экземпляр MainVM..</param>
        public AddCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }
    }
}
