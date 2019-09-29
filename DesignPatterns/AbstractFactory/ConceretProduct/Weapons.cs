using DesignPatterns.AbstractFactory.AbstractProduct;
using static DesignPatterns.AbstractFactory.Enumerations;

namespace DesignPatterns.AbstractFactory.ConceretProduct
{
    public class AK47 : IWeapon
    {
        public string GetWeapon() => Weapon.AK47.ToString();
    }

    public class AR15 : IWeapon
    {
        public string GetWeapon() => Weapon.AR15.ToString();
    }

    public class UZI : IWeapon
    {
        public string GetWeapon() => Weapon.UZI.ToString();
    }
}
