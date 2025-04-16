using System.Windows.Input;
using View.Model;

namespace View.ViewModel.Commands
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
        /// Исполняемая функция команды.
        /// </summary>
        /// <param name="parameter">Принимаемый параметр.</param>
        public void Execute(object parameter)
        {
            if (MainVM.IsEditing)
            {
                MainVM.Contacts[MainVM.IndexOfEditedContact] = MainVM.SelectedContact;
                MainVM.IndexOfEditedContact = -1;
                MainVM.IsEditing = false;
            }
            if (MainVM.IsAdding)
            {
                MainVM.Contacts.Add(new Contact(MainVM.SelectedContact));
                MainVM.SelectedContact = MainVM.Contacts.Last();
                MainVM.IsAdding = false;
            }
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