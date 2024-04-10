using Prohramming.Model.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prohramming.View.Tabs
{
    /// <summary>
    /// Хранит элементы вкладки Enums.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// При нажатии кнопки SeasonButton,
        /// если в SeasonComboBox выбраны поля
        /// Winter или Summer созадет MessageBox,
        /// иначе меняет цвет SeasonButton
        /// </summary>
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.Text)
            {
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!", "Сообщение");
                    break;
                case "Spring":
                    SeasonButton.BackColor = AppColours.GreenYellow;
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!", "Сообщение");
                    break;
                case "Autumn":
                    SeasonButton.BackColor = AppColours.Orange;
                    break;
            }
        }
    }
}
