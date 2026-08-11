using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Abstraction
{
    internal class FancyRhombus : Shape
    {
        private Shape triangle;
        //private Shape Tringle;

        public FancyRhombus(Shape triangle)
        {
            this.triangle = triangle;
            ;
        }
        public override double GetArea()
        {
            return 2 * triangle.GetArea();
        }
    }
}
