using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Polymorphism
{
    internal class Cow : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Moo");

            PlaySound("cow");

        }
    }
}
