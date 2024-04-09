using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    public class Subject
    {
        /// <summary>
        /// Хранит данные о школьном предмете.
        /// </summary>
        public string Name { get; set; }
        public string TeacherName { get; set; }
        private int _grade;
        public int Grade
        {
            get { return _grade; }
            set {
                Validator.AssertValueInRange(value, 2, 5, nameof(Grade));
                _grade = value;
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
