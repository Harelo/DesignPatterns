using DesignPatterns.AbstractFactory.AbstractInterface;
using DesignPatterns.AbstractFactory.ConcreteFactory;

namespace DesignPatterns.AbstractFactory.ConcreteFactory
{
    public class WinnerCarFactory
    {
        public IWeaponizedCarFactory Create(Person winner)
        {
            IWeaponizedCarFactory theCarFactory = null;

            if (winner.Age > 30)
            {
                if (winner.Gender == 1)
                    theCarFactory = new MonzdaFactory();
                else if (winner.Gender == 2)
                    theCarFactory = new MonzdaLiteFactory();
            }

            else if (winner.Age < 30 && winner.Age > 18)
            {
                if (winner.Gender == 1)
                    theCarFactory = new KiaDeathosFactory();
                else if (winner.Gender == 2)
                    theCarFactory = new KiaKillcantoFactory();
            }

            return theCarFactory;
        }
    }
}
