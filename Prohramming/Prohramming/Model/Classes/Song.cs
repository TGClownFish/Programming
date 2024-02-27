using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    internal class Song
    {
        public string Name { get; set; }
        public string MusicianName { get; set; }
        private int _durationSeconds;
        public int DurationSeconds
        {
            get { return _durationSeconds; }
            set
            {
                if (value >= 0)
                {
                    _durationSeconds = value;
                }
                else
                {
                    throw new ArgumentException("Введите значение выше 0");
                }
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
