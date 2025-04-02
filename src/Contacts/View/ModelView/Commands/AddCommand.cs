using System.Windows.Input;
using View.Model;

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
            
            MainVM.SelectedContact = new Contact();
            MainVM.IsAdding = true;
        }

        /// <summary>
        /// Создаёт объект класса <see cref="AddCommand"/>.
        /// </summary>
        /// <param name="mainVM">Ссылка на экземпляр MainVM.</param>
        public AddCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }
    }
}