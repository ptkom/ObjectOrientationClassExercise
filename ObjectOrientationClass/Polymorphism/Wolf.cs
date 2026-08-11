using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Polymorphism
{
    internal class Wolf : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("AWWOOO");

            PlaySound("wolf");
        }
    }
}
