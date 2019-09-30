using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class PrototypeTesterProgram
    {
        public static void RunTest()
        {
            PrototypeFactory animalMaker = new PrototypeFactory();
            Sheep sally = new Sheep() { Name = "Sally" };
            Sheep clonedSheep = (Sheep)sally.makeCopy();

            Console.WriteLine(sally.Name);
            Console.WriteLine(clonedSheep.Name);
        }
    }
}
