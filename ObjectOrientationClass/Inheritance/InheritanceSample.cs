using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Inheritance
{
    internal class InheritanceSample
    {
        public static void Run()
        {
            List<Person> People = new List<Person>();

            Person person = new Person("Barbie", "Roberts", Gender.Female, Race.African, 23, false);

            People.Add(person);

            Student student = new Student("264391", "8", "Software Engineering", "UWC", 5, "Ken", "Carson", Gender.Male, Race.Coloured, 24, true);

            People.Add(student);

            Employee employee = new Employee("1234", 3000000, "Programmer", "Bitcoint Inc", "A10023", EmploymentType.FullTime, "Cloe", "Bratz", Gender.Female, Race.White, 26, false);

            People.Add(employee);

            Pilot pilot = new Pilot(true, 10, FlyingType.Fighter, "65769", 12000, "Military Pilot", "US Air Force", "A10045", EmploymentType.Contract, "Simon", "Gates", Gender.Male, Race.White, 25, true);

            People.Add(pilot);
            /*
            foreach (Person singlePerson in People)
            {
                if (singlePerson is Employee)
                {
                    Employee singleEmployee = singlePerson as Employee;

                    if (singleEmployee.EmploymentType == EmploymentType.FullTime)
                    {
                        Console.WriteLine($"Full Name: {singlePerson.FullName}");
                    }
                }
            }
            */
            foreach (Person possibleStudent in People)
            {
                if (possibleStudent is Student)
                {
                    Student actualStudent = possibleStudent as Student;

                    Console.WriteLine($"Full Name: {possibleStudent.FullName}");
                    Console.Write($"Student Number: {actualStudent.StudentNumber}");

                }
                
                
            }

        }
    }
}
