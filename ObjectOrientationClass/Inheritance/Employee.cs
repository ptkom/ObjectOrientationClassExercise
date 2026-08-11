using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ObjectOrientationClass.Inheritance
{
    internal class Employee : Person
    {
        public Employee(string employeeNumber, decimal salary, string occupation, string company, string taxNumber, EmploymentType employmentType, string firstName, string surname, Gender gender, Race race, int age, bool deceased) : base(firstName, surname, gender, race, age, deceased)
        {
            EmployeeNumber = employeeNumber;
            Salary = salary;
            Occupation = occupation;
            Company = company;
            TaxNumber = taxNumber;
            EmploymentType = employmentType;
        }

        public string EmployeeNumber { get; set; }

        public decimal Salary { get; set; }

        public string Occupation { get; set; }

        public string Company { get; set; }

        public string TaxNumber { get; set; }

        public EmploymentType EmploymentType { get; set; }

        
    }
}
