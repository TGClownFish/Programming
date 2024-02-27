using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    internal class Subject
    {
        public string Name { get; set; }
        public string TeacherName { get; set; }
        private int _grade;
        public int Grade
        {
            get { return _grade; }
            set {
                if (value >= 2 && value <= 5)
                {
                    _grade = value;
                }
                else
                {
                    throw new ArgumentException("Введите значение между 2 и 5");
                }
            }
        }
        public Subject(string name, string teacherName, int grade)
        {
            Name = name;
            TeacherName = teacherName;
            Grade = grade;
        }
        public Subject ( ) { }
    }
}
