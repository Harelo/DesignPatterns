using DesignPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.AbstractFactory.AbstractInterface
{
    public interface IWeaponizedCarFactory
    {
        IWeapon Weapon();
        ICar Car();
        IEngine Engine();
    }
}
