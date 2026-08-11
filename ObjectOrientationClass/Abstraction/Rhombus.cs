using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Abstraction
{
    internal class Rhombus : Shape 
    {
        private double diagonal1;
        private double diagonal2;

        public Rhombus(double diagonal1, double diagonal2)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
        }
        public override double GetArea()
        {
            return 0.5 * diagonal1 * diagonal2;
        }

        
    }
}
