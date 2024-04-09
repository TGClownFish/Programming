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
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
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
