using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Polymorphism
{
    internal class Lion : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Roar");

            PlaySound("lion");
        }
    }
}
