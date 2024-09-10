using Prohramming.Model.Classes;
using Prohramming.Model.Classes.Geometry;
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
    /// Хранит элементы вкладки Classes.
    /// </summary>
    public partial class ClassesTabPage : UserControl
    {
        List<Model.Classes.Rectangle> _classesPageRrectangles = new List<Model.Classes.Rectangle>();
        Model.Classes.Rectangle _classesPageCurrentRectangle = new Model.Classes.Rectangle();
        public ClassesTabPage()
        {
            InitializeComponent();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                _classesPageRrectangles.Add(RectangleFactory.Randomize(rnd));
            }
        }

        /// <summary>
        /// При нажатии на кнопку classesPageFindButton, 
        /// находит прямоугольник с наибольшей шириной и
        /// выделяет его в classesPageListBox.
        /// </summary>
        private void classesPageFindButton_Click(object sender, EventArgs e)
        {
            int MaxIndex = 0;
            double MaxWidth = 0;
            for (int i = 0; i < 5; i++)
            {
                if (MaxWidth < _classesPageRrectangles.ElementAt(i).Width)
                {
                    MaxWidth = _classesPageRrectangles.ElementAt(i).Width;
                    MaxIndex = i;
                }
            }
            classesPageListBox.SelectedIndex = MaxIndex;
        }

        /// <summary>
        /// При изменении текста в classesPageColourTextBox
        /// пытается изменить поле Color в выбраном прямоугольнике
        /// на новое значение этого текстбокса.
        /// </summary>
        private void classesPageColourTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _classesPageRrectangles.ElementAt(classesPageListBox.SelectedIndex).Colour = classesPageColourTextBox.Text;
                classesPageColourTextBox.BackColor = Color.White;
            }
            catch
            {
                classesPageColourTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// При изменении текста в classesPageWidthTextBox
        /// пытается изменить поле Width в выбраном прямоугольнике
        /// на новое значение этого текстбокса.
        /// </summary>
        private void classesPageWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _classesPageRrectangles.ElementAt(classesPageListBox.SelectedIndex).Width = Convert.ToDouble(classesPageWidthTextBox.Text);
                classesPageWidthTextBox.BackColor = Color.White;
            }
            catch
            {
                classesPageWidthTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// При изменении текста в classesPageLengthTextBox
        /// пытается изменить поле Length в выбраном прямоугольнике
        /// на новое значение этого текстбокса.
        /// </summary>
        private void classesPageLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _classesPageRrectangles[classesPageListBox.SelectedIndex].Length = Convert.ToDouble(classesPageLengthTextBox.Text);
                classesPageLengthTextBox.BackColor = Color.White;
            }
            catch
            {
                classesPageLengthTextBox.BackColor = Color.LightPink;
            }


        }

        /// <summary>
        /// Если в classesPageListBox выбран прямоугольник,
        /// заменяет текст в текстбоксах на значения соотвествующих полей
        /// выбранного прямоугольника. 
        /// Иначе заменяет текст в этих текстбоксах на пустые строки.
        /// </summary>
        private void classesPageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classesPageListBox.SelectedIndex >= 0)
            {
                _classesPageCurrentRectangle = _classesPageRrectangles.ElementAt(classesPageListBox.SelectedIndex);
                classesPageIdTextBox.Text = Convert.ToString(_classesPageCurrentRectangle.Id);
                classesPageLengthTextBox.Text = Convert.ToString(_classesPageCurrentRectangle.Length);
                classesPageWidthTextBox.Text = Convert.ToString(_classesPageCurrentRectangle.Width);
                classesPageColourTextBox.Text = _classesPageCurrentRectangle.Colour;
                classesPageXTextBox.Text = Convert.ToString(_classesPageCurrentRectangle.Center.X);
                classesPageYTextBox.Text = Convert.ToString(_classesPageCurrentRectangle.Center.Y);
            }
            else
            {
                classesPageIdTextBox.Text = "";
                classesPageLengthTextBox.Text = "";
                classesPageWidthTextBox.Text = "";
                classesPageColourTextBox.Text = "";
                classesPageXTextBox.Text = "";
                classesPageYTextBox.Text = "";
            }
        }
    }
}
