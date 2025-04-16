using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using View.Model;

namespace View.Controls
{
    /// <summary>
    /// Interaction logic for ContactInfo.xaml
    /// </summary>
    public partial class ContactControl : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// Точка входа.
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();
            SelectedContactProperty = DependencyProperty.Register("SelectedContact", typeof(Contact), typeof(ContactControl));
        }

        /// <summary>
        /// Проверка вводимого текста в TextBox, хранящий данные о телефонном номере.
        /// </summary>
        /// <param name="sender">TextBox, в который вводится текст.</param>
        /// <param name="e">Данные о вводимом тексте.</param>
        private void PhoneNumberTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!"0123456789+-() ".Contains(e.Text))
                e.Handled = true;
        }
        public readonly DependencyProperty SelectedContactProperty;

        public Contact SelectedContact
        {
            get
            { return (Contact)GetValue(SelectedContactProperty); }
            set
            {
                SetValue(SelectedContactProperty, value);

                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Срабатывет, когда меняется свойство элемента.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Вызывает событие PropertyChanged.
        /// </summary>
        /// <param name="prop">Аргументы события.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
