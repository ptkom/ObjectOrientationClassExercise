using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Inheritance
{
    internal class Student : Person
    {
        public Student(string studentNumber, string nqfLevel, string course, string institutuion, int year, string firstName, string surname, Gender gender, Race race, int age, bool deceased) : base(firstName, surname, gender, race, age, deceased)
        {
            StudentNumber = studentNumber;
            NqfLevel = nqfLevel;
            Course = course;
            Institution = institutuion;
            Year = year;
        }

        public string StudentNumber { get; set; }

        public string NqfLevel { get; set; }

        public string Course { get; set; }

        public string Institution { get; set; }

        public int Year { get; set; }

       
    }
}
