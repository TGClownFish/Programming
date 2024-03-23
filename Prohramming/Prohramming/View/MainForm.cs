using Prohramming.Model.Classes;
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
        Model.Classes.Rectangle[] _rectangles = new Model.Classes.Rectangle[5];
        Model.Classes.Rectangle _currentRectangle = new Model.Classes.Rectangle();
        Film[] _films = new Film[5];
        Film _currentFilm = new Film();
        //Contact contact = new Contact("ff","1",12);
        public MainForm()
        {
            InitializeComponent();

            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Point2D newCentre = new Point2D(GetRandomDouble(-100, 100, rnd), GetRandomDouble(-100, 100, rnd));
                _rectangles[i] = new Model.Classes.Rectangle(GetRandomDouble(1, 50,rnd), GetRandomDouble(1, 50, rnd), "Blue", newCentre);
                _films[i] = new Film("f", rnd.Next(1, 20000), rnd.Next(1990, 2024), "ff", GetRandomDouble(1, 10, rnd) );
            }
        }
        public double GetRandomDouble(double minimum, double maximum, Random random)
        {
            return Math.Round((random.NextDouble() * (maximum - minimum) + minimum), 2);
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
            if (!int.TryParse(ParsingTextBox.Text, out _))
            {
                bool isParced = Enum.TryParse(ParsingTextBox.Text, out Weekday parced);
                if (isParced)
                {
                    int dayNumber = Convert.ToInt32(Enum.Parse(typeof(Weekday), ParsingTextBox.Text));
                    label5.Text = $"Это день недели ({ParsingTextBox.Text} = {Convert.ToString(dayNumber) + 1})";
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

        private void button1_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.Text)
            {
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!","Сообщение");
                    break;
                case "Spring":
                    SeasonGroupBox.BackColor = Color.GreenYellow;
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!","Сообщение");
                    break;
                case "Autumn":
                    SeasonGroupBox.BackColor = Color.Orange;
                    break;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.ValuesListBox.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Green",
            "Blue",
            "White",
            "Black",
            "Brown",
            "Gray"});
            this.ValuesListBox.SelectedIndex = 0;
            this.EnumsListBox.SelectedIndex = 0;
            this.NameTextBox.Text = "0";
            
        }


        private void rectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[rectanglesListBox.SelectedIndex];
            rectanglesIdTextBox.Text = Convert.ToString(_currentRectangle.Id);
            rectanglesLengthTextBox1.Text = Convert.ToString(_currentRectangle.Length);
            rectanglesWidthTextBox.Text = Convert.ToString(_currentRectangle.Width);
            rectanglesColourTextBox.Text = _currentRectangle.Colour;
            rectanglesXTextBox.Text = Convert.ToString(_currentRectangle.Center.X);
            rectanglesYTextBox.Text = Convert.ToString(_currentRectangle.Center.Y);
        }

        private void rectanglesLengthTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[rectanglesListBox.SelectedIndex].Length = Convert.ToDouble(rectanglesLengthTextBox1.Text);
                rectanglesLengthTextBox1.BackColor = Color.White;
            }
            catch
            { 
                rectanglesLengthTextBox1.BackColor = Color.LightPink; 
            }

            
        }
        private void rectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[rectanglesListBox.SelectedIndex].Width = Convert.ToDouble(rectanglesWidthTextBox.Text);
                rectanglesWidthTextBox.BackColor = Color.White;
            }
            catch
            {
                rectanglesWidthTextBox.BackColor = Color.LightPink;
            }
        }

        private void rectanglesColourTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[rectanglesListBox.SelectedIndex].Colour = rectanglesColourTextBox.Text;
                rectanglesColourTextBox.BackColor = Color.White;
            }
            catch
            {
                rectanglesColourTextBox.BackColor= Color.LightPink;
            }
        }
        private void rectanglesButton_Click(object sender, EventArgs e)
        {
            rectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] array)
        {
            int MaxIndex = 0;
            double MaxWidth = 0;
            for (int i  = 0; i < 5; i++)
            {
                if (MaxWidth < array[i].Width)
                {
                    MaxWidth = array[i].Width;
                    MaxIndex = i;
                }
            }
            return MaxIndex;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _films[listBox1.SelectedIndex];
            filmsNameTextBox.Text = Convert.ToString(_currentFilm.Name);
            durationTextBox.Text = Convert.ToString(_currentFilm.Duration);
            filmsReleaseYearTextBox.Text = Convert.ToString(_currentFilm.ReleaseYear);
            genreTextBox.Text = Convert.ToString(_currentFilm.Genre);
            ratingTextBox.Text = Convert.ToString(_currentFilm.Rating);
        }

        private void filmsNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _films[listBox1.SelectedIndex].Name = filmsNameTextBox.Text;
                filmsNameTextBox.BackColor = Color.White;
            }
            catch
            {
                filmsNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void durationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _films[listBox1.SelectedIndex].Duration = Convert.ToInt32(durationTextBox.Text);
                durationTextBox.BackColor = Color.White;
            }
            catch
            {
                durationTextBox.BackColor = Color.LightPink;
            }
        }

        private void filmsReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _films[listBox1.SelectedIndex].ReleaseYear = Convert.ToInt32(filmsReleaseYearTextBox.Text);
                filmsReleaseYearTextBox.BackColor = Color.White;
            }
            catch
            {
                filmsReleaseYearTextBox.BackColor = Color.LightPink;
            }
        }

        private void genreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _films[listBox1.SelectedIndex].Genre = genreTextBox.Text;
                genreTextBox.BackColor = Color.White;
            }
            catch
            {
                genreTextBox.BackColor = Color.LightPink;
            }
        }

        private void ratingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _films[listBox1.SelectedIndex].Rating = Convert.ToDouble(ratingTextBox.Text);
                ratingTextBox.BackColor = Color.White;
            }
            catch
            {
                ratingTextBox.BackColor = Color.LightPink;
            }
        }

        private void filmsButton_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = FindFilmleWithMaxRating(_films);
        }
        private int FindFilmleWithMaxRating(Film[] array)
        {
            int MaxIndex = 0;
            double MaxRating = 0;
            for (int i = 0; i < 5; i++)
            {
                if (MaxRating < array[i].Rating)
                {
                    MaxRating = array[i].Rating;
                    MaxIndex = i;
                }
            }
            return MaxIndex;
        }
    }
}
