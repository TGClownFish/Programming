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
    public partial class FilmsTabPage : UserControl
    {
        Film[] _films = new Film[5];
        Film _currentFilm = new Film();
        public FilmsTabPage()
        {
            InitializeComponent();

            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                _films[i] = new Film("f", rnd.Next(1, 20000), rnd.Next(1990, 2024), "ff", RandomDouble.GetRandomDouble(1, 10, rnd));
            }
        }

        private void filmsPageDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _films[filmsPageListBox.SelectedIndex].Duration = Convert.ToInt32(filmsPageDurationTextBox.Text);
                filmsPageDurationTextBox.BackColor = Color.White;
            }
            catch
            {
                filmsPageDurationTextBox.BackColor = Color.LightPink;
            }
        }

        private void filmsPageRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _films[filmsPageListBox.SelectedIndex].Rating = Convert.ToDouble(filmsPageRatingTextBox.Text);
                filmsPageRatingTextBox.BackColor = Color.White;
            }
            catch
            {
                filmsPageRatingTextBox.BackColor = Color.LightPink;
            }
        }

        private void filmsPageGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _films[filmsPageListBox.SelectedIndex].Genre = filmsPageGenreTextBox.Text;
                filmsPageGenreTextBox.BackColor = Color.White;
            }
            catch
            {
                filmsPageGenreTextBox.BackColor = Color.LightPink;
            }
        }

        private void filmPageFindButton_Click(object sender, EventArgs e)
        {
            filmsPageListBox.SelectedIndex = FindFilmWithMaxRating(_films);
        }

        private int FindFilmWithMaxRating(Film[] array)
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

        private void filmsPageReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _films[filmsPageListBox.SelectedIndex].ReleaseYear = Convert.ToInt32(filmsPageReleaseYearTextBox.Text);
                filmsPageReleaseYearTextBox.BackColor = Color.White;
            }
            catch
            {
                filmsPageReleaseYearTextBox.BackColor = Color.LightPink;
            }
        }

        private void filmsPageNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _films[filmsPageListBox.SelectedIndex].Name = filmsPageNameTextBox.Text;
                filmsPageNameTextBox.BackColor = Color.White;
            }
            catch
            {
                filmsPageNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void filmsPageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _films[filmsPageListBox.SelectedIndex];
            filmsPageNameTextBox.Text = Convert.ToString(_currentFilm.Name);
            filmsPageDurationTextBox.Text = Convert.ToString(_currentFilm.Duration);
            filmsPageReleaseYearTextBox.Text = Convert.ToString(_currentFilm.ReleaseYear);
            filmsPageGenreTextBox.Text = Convert.ToString(_currentFilm.Genre);
            filmsPageRatingTextBox.Text = Convert.ToString(_currentFilm.Rating);
        }
    }
}
