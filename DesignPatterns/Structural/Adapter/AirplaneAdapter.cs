using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class AirplaneAdapter : IVehicle
    {
        Airplane airplane;

        public AirplaneAdapter(Airplane _airplane)
        {
            this.airplane = _airplane;
        }

        public void AssignDriver(string driverName)
        {
            airplane.AssignPilot(driverName);
        }

        public void MoveForward()
        {
            airplane.FlyForward();
        }

        public void Stop()
        {
            airplane.Land();
        }
    }
}
