using System.Windows.Controls;

namespace View.Controls
{
    /// <summary>
    /// Interaction logic for ContactInfo.xaml
    /// </summary>
    public partial class ContactInfo : UserControl
    {
        public ContactInfo()
        {
            InitializeComponent();
        }

        private void PhoneNumberTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!"0123456789+-() ".Contains(e.Text))
                e.Handled = true;
        }
    }
}
