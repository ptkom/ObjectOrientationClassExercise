using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Polymorphism
{
    internal class Hyena : Animal
    {
        public override void MakeNoise() // 'Override'- to override the parent class
        {


            Console.WriteLine("HEHEHE");

            PlaySound("hyena");
        }
    }
}

