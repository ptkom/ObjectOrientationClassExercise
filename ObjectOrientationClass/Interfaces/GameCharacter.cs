using ObjectOrientationClass.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;
//using ObjectOrientationClass.Inheritance;

namespace ObjectOrientationClass.Interfaces
{
    internal class GameCharacter : Person, IDamagable, ILootable
    {
        public int Health { get; set; }
        public int Gold { get; set; }



        public GameCharacter(int health, int gold,string firstName, string surname, Gender gender, Race race, int age, bool deceased) : base(firstName, surname, gender, race, age, deceased)
        {
            Health = health;
            Gold = gold;
        }

        // Implement the Attack methos from thr IDamagable interface
        public void Attack()
        {
           
            var random = new Random();
            int healthToDecrease = random.Next(50);
            
            if (Health > healthToDecrease)
            {
                Health -= healthToDecrease;
            }

            else
            {
                Health = 0;
                Deceased = true;
            }
        }

        public void Steal()
        {
            var random = new Random();
            int goldToSteal = random.Next(10);


            if (Gold > goldToSteal)
            {
                Gold -= goldToSteal;
            }

            else
            {
                Gold = 0;
                
            }

            Gold -= goldToSteal;
        }
    }
}
