using System.Windows.Input;
using View.Model;

namespace View.ModelView.Commands
{
    /// <summary>
    /// Хранит команду редактирования.
    /// </summary>
    public class EditCommand : ICommand
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
            if (MainVM.IsReadOnly == true && MainVM.SelectedContact != null)
            { 
                MainVM.IndexOfEditedContact = MainVM.Contacts.IndexOf(MainVM.SelectedContact);
                MainVM.SelectedContact = new Contact(MainVM.SelectedContact);
                MainVM.IsEditing = true;
            }
        }

        /// <summary>
        /// Создаёт объект класса <see cref="EditCommand"/>.
        /// </summary>
        /// <param name="mainVM">Ссылка на экземпляр MainVM.</param>
        public EditCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }
    }
}