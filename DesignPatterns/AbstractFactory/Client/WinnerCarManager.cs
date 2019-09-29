using DesignPatterns.AbstractFactory.AbstractInterface;
using DesignPatterns.AbstractFactory.AbstractProduct;


namespace DesignPatterns.AbstractFactory.Client
{
    public class WinnerCarManager
    {
        IWeaponizedCarFactory IWeaponizedCarFactory;

        public WinnerCarManager(IWeaponizedCarFactory _IWeaponizedCarFactory)
        {
            this.IWeaponizedCarFactory = _IWeaponizedCarFactory;
        }

        public string GetCarDetails()
        {
            ICar car = IWeaponizedCarFactory.Car();
            IEngine engine = IWeaponizedCarFactory.Engine();
            IWeapon weapon = IWeaponizedCarFactory.Weapon();

            return string.Format("The winner's car is the following: {0} {1} {2}", car.GetCar(), engine.GetEngine(), weapon.GetWeapon());
        }
    }
}
