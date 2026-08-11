using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Polymorphism
{
    internal class Giraffe : Animal
    {
        public override void MakeNoise()
        {
            PlaySound("giraffe");
        }
    }
}
