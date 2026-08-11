using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClass.Polymorphism
{
    internal class PolymorhpismSample
    {
        public static void Run()
        {
            List<Animal> zoo = new List<Animal>();

            Animal animal = new Dog();

            zoo.Add(animal);


            animal = new Cow();

            zoo.Add(animal);

            animal = new Giraffe();

            zoo.Add(animal);


            animal = new Hyena();

            zoo.Add(animal);

            animal = new Wolf();
            zoo.Add(animal);

            animal = new Lion();
            zoo.Add(animal);

            animal = new Donkey();
            zoo.Add(animal);

            foreach (Animal cagedAnimal in zoo)
            {
                Console.Write($"{cagedAnimal.GetType().Name}   -");
                cagedAnimal.MakeNoise();

                Thread.Sleep(1000);
            }




        }
    }
}
