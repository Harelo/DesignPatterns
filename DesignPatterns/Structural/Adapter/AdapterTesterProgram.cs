using System.Collections.Generic;
using System;

namespace DesignPatterns.Adapter
{
    public class AdapterTesterProgram
    {
        public static void RunTest()
        {

            Car car = new Car();
            car.AssignDriver("Max");
            car.MoveForward();
            car.Stop();

            Console.WriteLine();

            Airplane airplane = new Airplane();
            airplane.AssignPilot("John");
            airplane.FlyForward();
            airplane.Land();

            Console.WriteLine();

            AirplaneAdapter adapter = new AirplaneAdapter(airplane);

            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(adapter);

            foreach(IVehicle v in vehicles)
            {
                v.AssignDriver("Ruth");
                v.MoveForward();
                v.Stop();
                Console.WriteLine();
            }
        }
    }
}
