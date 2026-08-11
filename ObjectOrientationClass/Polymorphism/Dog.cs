using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Polymorphism
{
    internal class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Woof");

            PlaySound("dog");
        }
    }
}

