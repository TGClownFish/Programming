using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    /// <summary>
    /// Хранит данные фильмов.
    /// </summary>
     public class Film
    {
        /// <summary>
        /// Название.
        /// </summary>
        private string _name;
        /// <summary>
        /// Возвращает и задаёт название фильма. Должно состоять из букв латинского алфавита.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }
        
        /// <summary>
        /// Длинна в секундах.
        /// </summary>
        private int _duration;
        /// <summary>
        /// Возвращает и задаёт длинну фильма. Должна быть положительна.
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Год выпуска.
        /// </summary>
        private int _releaseYear;
        /// <summary>
        /// Возвращает и задаёт год выпуска фильма. Должен между 1990 и 2024.
        /// </summary>
        public int ReleaseYear 
        { 
            get { return _releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 1990, 2024, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Жанр.
        /// </summary>
        public string _genre;
        /// <summary>
        /// Возвращает и задаёт жанр фильма. Должн состоять из букв латинского алфавита.
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set
            {
            Validator.AssertStringContainsOnlyLetters(value, nameof(Genre));
            _genre = value;
            }
        }

        /// <summary>
        /// Рейтинг.
        /// </summary>
        private double _rating;
        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Должен быть между 1 и 10.
        /// </summary>
        public double Rating 
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value, 1, 10, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Создаёт экземляр класса <see cref="Film"/>.
        /// </summary>
        /// <param name="name">Название. Должно состоять из букв латинского алфавита.</param>
        /// <param name="duration">Длинна фильма в секундах. Должна быть положительна.</param>
        /// <param name="releaseYear">Год выпуска фильма. Должен между 1990 и 2024.</param>
        /// <param name="genre">Жанр фильма. Должн состоять из букв латинского алфавита.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть между 1 и 10.</param>
        public Film (string name, int duration, int releaseYear, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Создаёт пустой экземляр класса <see cref="Film"/>.
        /// </summary>
        public Film ()
        { }

    }
}
