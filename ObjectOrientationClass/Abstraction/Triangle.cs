using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Abstraction
{
    internal class Triangle : Shape
    {
        private double baseLength;
        private double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }
        public override double GetArea()
        {
            return ((0.5 * baseLength) * height);
        }
    }
}
