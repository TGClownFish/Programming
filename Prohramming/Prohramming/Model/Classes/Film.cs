using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
     public class Film
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }
        
        private int _duration;
        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }
        private int _releaseYear;
        public int ReleaseYear 
        { 
            get { return _releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 1990, 2024, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }
        public string _genre;
        public string Genre
        {
            get { return _genre; }
            set
            {
            Validator.AssertStringContainsOnlyLetters(value, nameof(Genre));
            _genre = value;
            }
        }

        private double _rating;
        public double Rating 
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value, 1, 10, nameof(Rating));
                _rating = value;
            }
        }
        public Film (string name, int duration, int releaseYear, string genre, double rating)
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
