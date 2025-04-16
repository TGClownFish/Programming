using System.Windows.Input;

namespace View.ViewModel.Commands
{
    /// <summary>
    /// Хранит команду удаления.
    /// </summary>
    public class RemoveCommand : ICommand
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
        /// Исполняемая функция команды.
        /// </summary>
        /// <param name="parameter">Принимаемый параметр.</param>
        public void Execute(object parameter)
        {
            MainVM.Contacts.Remove(MainVM.SelectedContact);
        }

        /// <summary>
        /// Создаёт объект класса <see cref="RemoveCommand"/>.
        /// </summary>
        /// <param name="mainVM">Ссылка на экземпляр MainVM.</param>
        public RemoveCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }
    }
}