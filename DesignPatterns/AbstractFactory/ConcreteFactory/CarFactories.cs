using DesignPatterns.AbstractFactory.AbstractInterface;
using DesignPatterns.AbstractFactory.AbstractProduct;
using DesignPatterns.AbstractFactory.ConceretProduct;

namespace DesignPatterns.AbstractFactory.ConcreteFactory
{
    public class MonzdaFactory : IWeaponizedCarFactory
    {
        public ICar Car() => new Mazda();
        public virtual IEngine Engine() => new N55();

        public virtual IWeapon Weapon() => new UZI();
    }

    public class MonzdaLiteFactory : MonzdaFactory
    {
        public override IEngine Engine() => new N45();
        public override IWeapon Weapon() => new AR15();
    }

    public class KiaKillcanto : IWeaponizedCarFactory
    {
        public ICar Car() => new Kia();
        public IEngine Engine() => new N65();
        public IWeapon Weapon() => new AK47();
    }

    public class KiaDeathos : IWeaponizedCarFactory
    {
        public ICar Car() => new Kia();
        public IEngine Engine() => new N55();
        public IWeapon Weapon() => new UZI();
    }
}
