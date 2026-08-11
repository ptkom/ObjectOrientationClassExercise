using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOrientationClass.Inheritance
{
    internal class Pilot : Employee
    {
        public Pilot(bool liscensed, double hoursFlown, FlyingType flyingType, string employeeNumber, decimal salary, string occupation, string company, string taxNumber, EmploymentType employmentType, string firstName, string surname, Gender gender, Race race, int age, bool deceased) : base(employeeNumber, salary, occupation, company, taxNumber, employmentType, firstName, surname, gender, race, age, deceased)
        {
            Liscensed = liscensed;
            HoursFlown = hoursFlown;
            FlyingType = flyingType;
        }

        public bool Liscensed { get; set; }

        public double HoursFlown { get; set; }

        public FlyingType FlyingType { get; set; }

       
    }
}
