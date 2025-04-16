using System.Windows.Controls;

namespace View.Controls
{
    /// <summary>
    /// Interaction logic for ContactInfo.xaml
    /// </summary>
    public partial class ContactInfo : UserControl
    {
        /// <summary>
        /// Точка входа.
        /// </summary>
        public ContactInfo()
        {
            InitializeComponent();
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
    }
}
