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


        private void ParsingButton_Click(object sender, EventArgs e)
        {
            bool isParced = Enum.TryParse(ParsingTextBox.Text, out Weekday parced);
            if (isParced)
            {
                int dayNumber = Convert.ToInt32(Enum.Parse(typeof(Weekday), ParsingTextBox.Text));
                label5.Text = $"Это день недели ({ParsingTextBox.Text} = {Convert.ToString(dayNumber)})";
            }
            else
            {
                label5.Text = "Нет такого дня недели";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.Text)
            {
                case "Winter":
                    MessageBox.Show(
                    "Бррр! Холодно!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    break;
                case "Spring":
                    SeasonGroupBox.BackColor = Color.GreenYellow;
                    break;
                case "Summer":
                    MessageBox.Show(
                    "Ура! Солнце!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    break;
                case "Autumn":
                    SeasonGroupBox.BackColor = Color.Orange;
                    break;
            }
        }
    }
}
