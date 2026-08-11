using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ObjectOrientationClass.Abstraction
{
    internal class Square : Shape
    {
        private double length;

        public Square (double length)
        {
         this.length = length;   
        }
        

        public override double GetArea()
        {
            return length * length;
        }
}   }

        
    

