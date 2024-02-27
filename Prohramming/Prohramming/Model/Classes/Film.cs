using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    internal class Film
    {
        public string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!int.TryParse(value, out _))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Введите слово");
                }
            }
        }

        private int _duration;
        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value >= 0)
                {
                    _duration = value;
                }
                else
                {
                    throw new ArgumentException("Введите значение выше нуля");
                }
            }
        }
        private int _releaseYear;
        public int ReleaseYear 
        { 
            get { return _releaseYear; }
            set
            {
                if (value >= 1990)
                {
                    _releaseYear = value;
                }
                else
                {
                    throw new ArgumentException("Введите значение выше 1990");
                }
            }
        }
        public string _genre;
        public string Genre
        {
            get { return _genre; }
            set
            {
                if (!int.TryParse(value, out _))
                {
                    _genre = value;
                }
                else
                {
                    throw new ArgumentException("Введите слово");
                }
            }
        }

        private int _rating;
        public int Rating 
        {
            get { return _rating; }
            set
            {
                if ( 1 <= value && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new ArgumentException("Введите значение между 1 и 10");
                }
            }
        }
        public Film (string name, int duration, int releaseYear, string genre, int rating)
        {
            Name = name;
            Duration = duration;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;

        }
        public Film ()
        { }

    }
}
