using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    public class Song
    {
        /// <summary>
        /// Хранит данные о песне.
        /// </summary>
        public string Name { get; set; }
        public string MusicianName { get; set; }

        private int _durationSeconds;
        public int DurationSeconds
        {
            get { return _durationSeconds; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationSeconds));
                _durationSeconds = value;
            }
        }
        public Song( string name, string musicianName , int durationSeconds )
        {
            Name = name;
            MusicianName = musicianName;
            DurationSeconds = durationSeconds;
        }
        public Song() { }
    }
}
