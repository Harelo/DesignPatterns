using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class Car : IVehicle
    {
        public void AssignDriver(string driverName)
        {
            Console.WriteLine(driverName + " is driving the car");
        }

        public void MoveForward()
        {
            Console.WriteLine("The car starts to drive forward");
        }

        public void Stop()
        {
            Console.WriteLine("The breaks have been pressed and the car has stopped");
        }
    }
}
