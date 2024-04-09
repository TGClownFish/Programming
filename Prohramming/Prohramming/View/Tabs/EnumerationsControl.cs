using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prohramming.View.Tabs
{
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTextBox.Text = Convert.ToString(ValuesListBox.SelectedIndex);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedItem)
            {
                case "Colour":
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Colour)));
                    break;
                case "EducationForm":
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(EducationForm)));
                    break;
                case "Genre":
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Genre)));
                    break;
                case "Manufacturer":
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Manufacturer)));
                    break;
                case "Season":
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Season)));
                    break;
                case "Weekday":
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Weekday)));
                    break;
            }
            ValuesListBox.SelectedIndex = 0;
        }
    }
}
