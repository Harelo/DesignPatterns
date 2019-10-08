using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class FlyweightTesterProgram
    {
        public static void RunTest()
        {
            string[] animals = new string[] { "Rhino", "Penguin", "Tiger" };
            AnimalFactory factory = new AnimalFactory();

            foreach (string a in animals)
            {
                //This is the extrinsic state
                Random rnd = new Random();
                Animal animal = factory.GetAnimal(a);
                animal.DisplayAmount(rnd.Next(1,11));
            }

        }
    }
}
