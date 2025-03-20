using System.Windows.Input;
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
        /// Срабатывет, если CanExecute изменил значение (это никогда не произойдёт).
        /// </summary>
        public event EventHandler CanExecuteChanged;

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
        /// Создаёт объект класса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="mainVM">Ссылка на экземпляр MainVM..</param>
        public SaveCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }
    }
}
