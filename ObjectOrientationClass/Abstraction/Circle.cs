using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ObjectOrientationClass.Abstraction
{
    
    internal class Circle : Shape 
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            // pi  * r * r
            return Math.PI * radius * radius;
        }

      
    }
}
