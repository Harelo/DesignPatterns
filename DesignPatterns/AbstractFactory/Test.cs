using DesignPatterns.AbstractFactory.AbstractInterface;
using DesignPatterns.AbstractFactory.Client;
using DesignPatterns.AbstractFactory.ConcreteFactory;
using System;

namespace DesignPatterns.AbstractFactory
{
    public class Test
    {
        public static void RunTest()
        {
            Person winnerA = new Person();
            winnerA.Age = 29;
            winnerA.Gender = 1;

            IWeaponizedCarFactory factory = new WinnerCarFactory().Create(winnerA);
            WinnerCarManager manager = new WinnerCarManager(factory);

            Console.WriteLine(manager.GetCarDetails());
        }
    }
}
