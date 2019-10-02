using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class Airplane
    {
        public void AssignPilot(string pilotName)
        {
            Console.WriteLine(pilotName + " is flying the airplane");
        }

        public void FlyForward()
        {
            Console.WriteLine("The airplane is flying forward");
        }

        public void Land()
        {
            Console.WriteLine("The pilot landed the airplane successfully");
        }
    }
}
