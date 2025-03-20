using System.Windows;
using System.Windows.Input;

namespace View.ModelView.Commands
{
    /// <summary>
    /// Хранит команду потверждения.
    /// </summary>
    public class ApplyCommand : ICommand
    {
        /// <summary>
        /// Ссылка на экземпляр MainVM.
        /// </summary>
        private MainVM MainVM { get; }

        /// <summary>
        /// Срабатывет, если CanExecute изменил значение (это никогда не произойдёт).
        /// </summary>
        public event EventHandler CanExecuteChanged;

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
            MessageBox.Show("Apply");
        }

        /// <summary>
        /// Создаёт объект класса <see cref="ApplyCommand"/>.
        /// </summary>
        /// <param name="mainVM">Ссылка на экземпляр MainVM.</param>
        public ApplyCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }
    }
}