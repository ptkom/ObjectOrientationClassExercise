using ObjectOrientationClass.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Interfaces
{
    internal class Dragon : GameCharacter
    {
        public Dragon(int health, int gold, string firstName, string surname, Gender gender, Race race, int age, bool deceased) : base(health, gold, firstName, surname, gender, race, age, deceased)
        {

        }
    }
}
