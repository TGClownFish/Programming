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
    /// <summary>
    ///  Хранит элементы вкладки Enums.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// При нажатии кнопки ParsingButton,
        /// если в ParsingTextBox введёно возможное
        /// значение <see cref="Weekday"/>, выводит
        /// в label5 индекс этого значения.
        /// </summary>
        private void ParsingButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ParsingTextBox.Text, out _))
            {
                bool isParced = Enum.TryParse(ParsingTextBox.Text, out Weekday parced);
                if (isParced)
                {
                    int dayNumber = Convert.ToInt32(Enum.Parse(typeof(Weekday), ParsingTextBox.Text));
                    label5.Text = $"Это день недели ({ParsingTextBox.Text} = {Convert.ToString(dayNumber + 1)})";
                }
                else
                {
                    label5.Text = "Нет такого дня недели";
                }
            }
            else
            {
                label5.Text = "Введите слово";
            }
        }
    }
}
