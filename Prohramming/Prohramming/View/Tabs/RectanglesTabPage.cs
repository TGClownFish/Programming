using Prohramming.Model.Classes.Geometry;
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
    public partial class RectanglesTabPage : UserControl
    {
        List<Model.Classes.Rectangle> _rectanglesTabPageRectangles = new List<Model.Classes.Rectangle>();
        Model.Classes.Rectangle _rectanglesTabPagCurrentRectangle = new Model.Classes.Rectangle();
        List<Panel> _rectanglePanels = new List<Panel>();
        public RectanglesTabPage()
        {
            InitializeComponent();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Model.Classes.Rectangle newRectangle = RectangleFactory.Randomize(rnd);
                _rectanglesTabPageRectangles.Add(newRectangle);

                rectanglesPageListBox.Items.Add(TurnRectangleToString(_rectanglesTabPageRectangles.ElementAt(i)));
                CreateNewPanel(newRectangle);
            }
            FindCollisions(_rectanglePanels, _rectanglesTabPageRectangles);
        }
        public string TurnRectangleToString(Model.Classes.Rectangle rectangle)
        {
            return $"({rectangle.Id}: X={rectangle.Center.X},Y={rectangle.Center.Y},W={rectangle.Width},L={rectangle.Length})";
        }
        private void rectanglesPageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rectanglesPageListBox.SelectedIndex >= 0)
            {
                _rectanglesTabPagCurrentRectangle = _rectanglesTabPageRectangles.ElementAt(rectanglesPageListBox.SelectedIndex);
                rectanglesPageIdTextBox.Text = Convert.ToString(_rectanglesTabPagCurrentRectangle.Id);
                rectanglesPageXTextBox.Text = Convert.ToString(_rectanglesTabPagCurrentRectangle.Center.X);
                rectanglesPageYTextBox.Text = Convert.ToString(_rectanglesTabPagCurrentRectangle.Center.Y);
                rectanglesPageWidthTextBox.Text = Convert.ToString(_rectanglesTabPagCurrentRectangle.Width);
                rectanglesPageLenghtTextBox.Text = Convert.ToString(_rectanglesTabPagCurrentRectangle.Length);
            }
            else
            {
                rectanglesPageIdTextBox.Text = "";
                rectanglesPageXTextBox.Text = "";
                rectanglesPageYTextBox.Text = "";
                rectanglesPageWidthTextBox.Text = "";
                rectanglesPageLenghtTextBox.Text = "";
            }
        }

        private void rectanglesPageDeleteButton_Click(object sender, EventArgs e)
        {
            if (rectanglesPageListBox.SelectedIndex >= 0)
            {
                ClearRectangleInfo();
                label25.Visible = false;
                label26.Visible = false;
            }
            else
            {
                label25.Visible = true;
                label26.Visible = true;
            }
        }

        private void rectanglesPageAddButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Model.Classes.Rectangle newRectangle = RectangleFactory.Randomize(rnd);

            _rectanglesTabPageRectangles.Add(newRectangle);
            rectanglesPageListBox.Items.Add(TurnRectangleToString(newRectangle));
            CreateNewPanel(newRectangle);
        }

        public Panel CreateNewPanel(Model.Classes.Rectangle newRectangle)
        {
            Panel newPanel = new Panel();
            newPanel.Location = new Point(newRectangle.Center.X, newRectangle.Center.Y);
            newPanel.Width = Convert.ToInt32(newRectangle.Width);
            newPanel.Height = Convert.ToInt32(newRectangle.Length);
            newPanel.BackColor = AppColours.Green;
            rectanglesPagePanel.Controls.Add(newPanel);
            _rectanglePanels.Add(newPanel);
            return newPanel;
        }

        private void FindCollisions(List<Panel> _rectanglePanels, List<Model.Classes.Rectangle> _rectangles)
        {

            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = AppColours.Green;
            }
            for (int i = 0; i < _rectanglePanels.Count; i++)
                for (int j = i + 1; j < _rectanglePanels.Count; j++)
                    if (CollisionManager.IsCollision(_rectangles.ElementAt(i), _rectangles.ElementAt(j)))
                    {
                        _rectanglePanels.ElementAt(i).BackColor = AppColours.Red;
                        _rectanglePanels.ElementAt(j).BackColor = AppColours.Red;
                    }
        }

        private void rectanglesPageWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectanglesTabPageRectangles.ElementAt(rectanglesPageListBox.SelectedIndex).Width = Convert.ToDouble(rectanglesPageWidthTextBox.Text);
                rectanglesPageWidthTextBox.BackColor = Color.White;
                UpdateRectangleInfo(rectanglesPageListBox.SelectedIndex);
            }
            catch
            {
                rectanglesPageWidthTextBox.BackColor = Color.LightPink;
            }
        }

        private void rectanglesPageLenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectanglesTabPageRectangles.ElementAt(rectanglesPageListBox.SelectedIndex).Length = Convert.ToDouble(rectanglesPageLenghtTextBox.Text);
                rectanglesPageLenghtTextBox.BackColor = Color.White;
                UpdateRectangleInfo(rectanglesPageListBox.SelectedIndex);
            }
            catch
            {
                rectanglesPageLenghtTextBox.BackColor = Color.LightPink;
            }
        }
        private void UpdateRectangleInfo(int SelectedIndex)
        {
            rectanglesPageListBox.Items[SelectedIndex] = TurnRectangleToString(_rectanglesTabPageRectangles.ElementAt(SelectedIndex));
            _rectanglePanels.ElementAt(SelectedIndex).Location = new Point(_rectanglesTabPagCurrentRectangle.Center.X, _rectanglesTabPagCurrentRectangle.Center.Y);
            _rectanglePanels.ElementAt(SelectedIndex).Width = Convert.ToInt32(_rectanglesTabPagCurrentRectangle.Width);
            _rectanglePanels.ElementAt(SelectedIndex).Height = Convert.ToInt32(_rectanglesTabPagCurrentRectangle.Length);

            FindCollisions(_rectanglePanels, _rectanglesTabPageRectangles);
        }
        private void ClearRectangleInfo()
        {
            _rectanglePanels.RemoveAt(rectanglesPageListBox.SelectedIndex);
            rectanglesPagePanel.Controls.RemoveAt(rectanglesPageListBox.SelectedIndex);
            _rectanglesTabPageRectangles.RemoveAt(rectanglesPageListBox.SelectedIndex);
            rectanglesPageListBox.Items.RemoveAt(rectanglesPageListBox.SelectedIndex);
            FindCollisions(_rectanglePanels, _rectanglesTabPageRectangles);
        }
    }
}
