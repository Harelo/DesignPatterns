using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class PrototypeTesterProgram
    {
        public static void Main()
        {
            Sheep sally = new Sheep() { Name = "Sally" };
            Sheep clonedSheep = (Sheep)sally.Clone();

            Console.WriteLine(sally.Name);
            Console.WriteLine(clonedSheep.Name);
        }
    }
}
