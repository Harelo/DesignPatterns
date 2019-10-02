namespace DesignPatterns.Adapter
{
    public interface IVehicle
    {
        void MoveForward();
        void AssignDriver(string driverName);
        void Stop();
    }
}
