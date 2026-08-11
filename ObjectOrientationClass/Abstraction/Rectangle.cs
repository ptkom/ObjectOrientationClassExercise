using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Abstraction
{
    internal class Rectangle : Shape
    {
        private double length;
        private double height;


        public Rectangle(double length, double height)
        {
            this.length = length;
            this.height = height;
        }
        public override double GetArea()
        {
          return length * height;
        }
    }
}
