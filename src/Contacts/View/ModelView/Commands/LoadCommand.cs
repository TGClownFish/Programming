using System.Windows.Input;
using View.Model.Services;

namespace View.ModelView
{
    /// <summary>
    /// Хранит команду загрузки.
    /// </summary>
    public class LoadCommand : ICommand
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
            MainVM.Contacts = ContactSerializer.Deserialize();
        }

        /// <summary>
        /// Создаёт объект класса <see cref="LoadCommand"/>.
        /// </summary>
        /// <param name="mainVM">Ссылка на экземпляр MainVM..</param>
        public LoadCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }
    }
}
