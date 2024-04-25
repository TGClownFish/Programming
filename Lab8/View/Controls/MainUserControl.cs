﻿using Lab8.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8.View.Controls
{
    public partial class MainUserControl : UserControl
    {
        List<Contact> _contacts = new List<Contact>();
        Contact _curentContact = new Contact();
        //string filePath = "C:\\Users\\5731lis\\AppData\\Local\\Lysenko\\Lab8\\Lab8_data.txt";
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Lysenko\\Lab8\\Lab8_data.txt");
        public MainUserControl()
        {
            InitializeComponent();
        }

        public void mainUserControlListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainUserControlListBox.SelectedIndex >= 0)
            {
                mainUserControlListBox.SelectedIndex = mainUserControlListBox.SelectedIndex;
                _curentContact = _contacts[mainUserControlListBox.SelectedIndex];
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
            mainUserControlListBox.SelectedIndex= mainUserControlListBox.Items.Count-1;
            mainUserControlEditElementButton_Click(sender, e);
        }

        private void mainUserControlNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contacts.ElementAt(mainUserControlListBox.SelectedIndex).FullName = mainUserControlNameTextBox.Text;
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
                _contacts.ElementAt(mainUserControlListBox.SelectedIndex).DateBirth = mainUserControllDateTimePicker.Value;
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
                _contacts.ElementAt(mainUserControlListBox.SelectedIndex).PhoneNumber = mainUserControlPhoneNumberTextBox.Text;
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
                _contacts.ElementAt(mainUserControlListBox.SelectedIndex).Link = mainUserControlLinkTextBox.Text;
                mainUserControlLinkTextBox.BackColor = Color.White;
            }
            catch
            {
                mainUserControlLinkTextBox.BackColor = Color.LightPink;
            }
        }

        private void mainUserControlEditElementButton_Click(object sender, EventArgs e)
        {
            if (mainUserControlListBox.SelectedIndex >= 0)
            {
                mainUserControlLinkTextBox.ReadOnly = false;
                mainUserControllDateTimePicker.Enabled = true;
                mainUserControlPhoneNumberTextBox.ReadOnly = false;
                mainUserControlNameTextBox.ReadOnly = false;
                mainUserControlListBox.Enabled = false;
                mainUserControlSaveElementButton.Enabled = true;
                mainUserControlAddNewElementButton.Enabled = false;
                mainUserControlDeleteElementButton.Enabled = false;
                mainUserControlEditElementButton.Enabled = false;
            }
        }

        private void mainUserControlSaveElementButton_Click(object sender, EventArgs e)
        {
            if (mainUserControlNameTextBox.Text == "")
            {
                errorLabel.Text = "No Name Entered";
            }
            else
            {
                mainUserControlLinkTextBox.ReadOnly = true;
                mainUserControllDateTimePicker.Enabled = false;
                mainUserControlPhoneNumberTextBox.ReadOnly = true;
                mainUserControlNameTextBox.ReadOnly = true;
                mainUserControlListBox.Enabled = true;
                mainUserControlSaveElementButton.Enabled = false;
                mainUserControlDeleteElementButton.Enabled = true;
                mainUserControlAddNewElementButton.Enabled = true;
                mainUserControlEditElementButton.Enabled = true;
                mainUserControlListBox.Items[mainUserControlListBox.SelectedIndex] = _contacts.ElementAt(mainUserControlListBox.SelectedIndex).FullName;
                errorLabel.Text = "";
                _contacts.Sort((x, y) => x.FullName.CompareTo(y.FullName));
                mainUserControlListBox.Items.Clear();
                for (int i = 0; i< _contacts.Count; i++)
                {
                    mainUserControlListBox.Items.Add(_contacts[i].FullName);
                }
                mainUserControlListBox.SelectedIndex = -1;
            }
        }

        private void mainUserControlDeleteElementButton_Click(object sender, EventArgs e)
        {
            if (mainUserControlListBox.SelectedIndex>=0)
            {
                mainUserControllDateTimePicker.Value = DateTime.Today.AddDays(-1);
                mainUserControlLinkTextBox.Text = "";
                mainUserControlNameTextBox.Text = "";
                mainUserControlPhoneNumberTextBox.Text = "";
                _contacts.RemoveAt(mainUserControlListBox.SelectedIndex);
                mainUserControlListBox.Items.RemoveAt(mainUserControlListBox.SelectedIndex);
                mainUserControlListBox.SelectedIndex = -1;
            }
        }

        public void MainUserControl_Load(object sender, EventArgs e)
        {
            int i = 0;
            string newLine;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while ((newLine=reader.ReadLine()) != null)
                {
                    _contacts.Add(new Contact());
                    _contacts.ElementAt(i).FullName = newLine;
                    _contacts.ElementAt(i).DateBirth = Convert.ToDateTime(reader.ReadLine());
                    _contacts.ElementAt(i).PhoneNumber = reader.ReadLine();
                    _contacts.ElementAt(i).Link = reader.ReadLine();
                    i++;
                }
                _contacts.Sort((x, y) => x.FullName.CompareTo(y.FullName));
                for (i = 0; i < _contacts.Count; i++)
                {
                    if (_contacts.ElementAt(i).FullName == "")
                        mainUserControlListBox.Items.Add("!Empty Contact");
                    else
                        mainUserControlListBox.Items.Add(_contacts.ElementAt(i).FullName);
                    
                }
                
            }
        }
        public void MainUserControl_HandleDestroyed(object sender, EventArgs e)
        {
            File.Delete(filePath);
            using (StreamWriter stream = new StreamWriter(File.Create(filePath)))
            {
                for (int i = 0; i < _contacts.Count; i++)
                {
                    stream.WriteLine(_contacts.ElementAt(i).FullName);
                    stream.WriteLine(_contacts.ElementAt(i).DateBirth);
                    stream.WriteLine(_contacts.ElementAt(i).PhoneNumber);
                    stream.WriteLine(_contacts.ElementAt(i).Link);
                }
            }
        }

    }
}
