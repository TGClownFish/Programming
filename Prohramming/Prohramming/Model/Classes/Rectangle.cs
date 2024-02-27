using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    internal class Rectangle
    {
        private int _length;
        public int Length
        {
            get{return _length;}
            set
            {
                if (value >= 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("Введите значение выше нуля");
                }
            }
        }
        private int _width;
        public int Width
        {
            get{return _width;}
            set
            {
                if (value >= 0)
                {
                    _width = value;
                }
                else
                { 
                    throw new ArgumentException("Введите значение выше нуля");
                }
            }
        }
        private string _colour;
        public string Colour 
        { 
            get { return _colour; }
            set
            {
                if (!int.TryParse(value, out _))
                {
                    _colour = value;
                }
                else
                {
                    throw new ArgumentException("Введите слово");
                }
            }
        }
        public Rectangle (int length, int width, string colour)
        {
            Length = length;
            Width = width;
            Colour = colour;
        }
        public Rectangle () { }
    }
}
