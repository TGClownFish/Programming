using Lab8.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8.View.Controls
{
    public partial class MainUserControl : UserControl
    {
        List<Contact> _contacts = new List<Contact>();
        Contact _curentContact = new Contact();
        bool haveUnsavedContact=false;
        int indexOfSelectedControl =0 ;
        public MainUserControl()
        {
            InitializeComponent();
        }

        public void mainUserControlListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainUserControlListBox.SelectedIndex > 0)
            {
                indexOfSelectedControl = mainUserControlListBox.SelectedIndex;
                _curentContact = _contacts[indexOfSelectedControl];
                mainUserControllDateTimePicker.Text = Convert.ToString(_curentContact.DateBirth);
                mainUserControlNameTextBox.Text = Convert.ToString(_curentContact.FullName);
                mainUserControlPhoneNumberTextBox.Text = Convert.ToString(_curentContact.PhoneNumber);
                mainUserControlLinkTextBox.Text = Convert.ToString(_curentContact.Link);
            }
        }

        public void mainUserControlAddNewElementButton_Click(object sender, EventArgs e)
        {
            Contact _newContact = new Contact("",DateTime.Today.AddDays(-1), "+","");
            _contacts.Add(_newContact);
            mainUserControlListBox.Items.Add("Empty Contact");

        }

        private void mainUserControlNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contacts.ElementAt(indexOfSelectedControl).FullName = mainUserControlNameTextBox.Text;
                mainUserControlNameTextBox.BackColor = Color.White;
            }
            catch
            {
                mainUserControlNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void mainUserControllDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contacts.ElementAt(indexOfSelectedControl).DateBirth = mainUserControllDateTimePicker.Value;
                mainUserControllDateTimePicker.BackColor = Color.White;
            }
            catch
            {
                mainUserControllDateTimePicker.BackColor = Color.LightPink;
            }
        }

        private void mainUserControlPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contacts.ElementAt(indexOfSelectedControl).PhoneNumber = mainUserControlPhoneNumberTextBox.Text;
                mainUserControlPhoneNumberTextBox.BackColor = Color.White;
            }
            catch
            {
                mainUserControlPhoneNumberTextBox.BackColor = Color.LightPink;
            }
        }

        private void mainUserControlLinkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contacts.ElementAt(indexOfSelectedControl).Link = mainUserControlLinkTextBox.Text;
                mainUserControlLinkTextBox.BackColor = Color.White;
            }
            catch
            {
                mainUserControlLinkTextBox.BackColor = Color.LightPink;
            }
        }

        private void mainUserControlEditElementButton_Click(object sender, EventArgs e)
        {
            mainUserControlLinkTextBox.ReadOnly= false;
            mainUserControllDateTimePicker.Enabled = true;
            mainUserControlPhoneNumberTextBox.ReadOnly = false;
            mainUserControlNameTextBox.ReadOnly = false;
            mainUserControlListBox.Enabled = false;
        }

        private void mainUserControlSaveElementButton_Click(object sender, EventArgs e)
        {
            mainUserControlLinkTextBox.ReadOnly = true;
            mainUserControllDateTimePicker.Enabled = false;
            mainUserControlPhoneNumberTextBox.ReadOnly = true;
            mainUserControlNameTextBox.ReadOnly = true;
            mainUserControlListBox.Enabled = true;

            mainUserControlListBox.Items[indexOfSelectedControl] = _contacts.ElementAt(indexOfSelectedControl).FullName; 
        }
    }
}
