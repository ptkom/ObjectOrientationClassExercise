using ObjectOrientationClass.Abstraction;
using ObjectOrientationClass.Encapsulation;
using ObjectOrientationClass.Inheritance;
using ObjectOrientationClass.Polymorphism;
using ObjectOrientationClass.Interfaces;
using System.ComponentModel.Design;


namespace ObjectOrientationClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EncapsulationSample.Run();
            //AbstractionSample.Run();
            //InheritanceSample.Run();
            //PolymorhpismSample.Run();

            InterfacesSample sample = new InterfacesSample();
            sample.Run();
        }

    }
}
