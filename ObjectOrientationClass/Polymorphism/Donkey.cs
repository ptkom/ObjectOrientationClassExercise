using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Polymorphism
{
    internal class Donkey : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("YEEHAW");

            PlaySound("donkey");
        }
    }
}
