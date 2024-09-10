using Prohramming.Model.Classes;
using Prohramming.Model.Classes.Geometry;
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

namespace Prohramming
{
    /// <summary>
    /// Главная вкладка программы.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
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
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Model.Enums.Colour)));
                    break;
                case "EducationForm":
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Model.Enums.EducationForm)));
                    break;
                case "Genre":
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Model.Enums.Genre)));
                    break;
                case "Manufacturer":
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Model.Enums.Manufacturer)));
                    break;
                case "Season":
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Model.Enums.Season)));
                    break;
                case "Weekday":
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Model.Enums.Weekday)));
                    break;
            }
            ValuesListBox.SelectedIndex = 0;
        }


        private void ParsingButton_Click(object sender, EventArgs e)
        {
            bool isParced = Enum.TryParse(ParsingTextBox.Text, out Model.Enums.Weekday parced);
            if (isParced)
            {
                int dayNumber = Convert.ToInt32(Enum.Parse(typeof(Model.Enums.Weekday), ParsingTextBox.Text));
                label5.Text = $"Это день недели ({ParsingTextBox.Text} = {Convert.ToString(dayNumber)})";
            }
            else
            {
                label5.Text = "Нет такого дня недели";
            }
        }

        }
    }
}
