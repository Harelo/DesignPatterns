using System;

namespace DesignPatterns.TemplateMethod
{
    public class DoubleCheeseBurger : Hamburger
    {
        string[] cheeseUsed = new string[] { "Provolone", "Provolone" };
        string[] veggieUsed = new string[] { "Lettuce", "Tomatoes", "Onions", "Pickle" };

        public override void addCheese()
        {
            foreach (string c in cheeseUsed)
                Console.WriteLine("Added cheese: " + c);
        }

        public override void addMeat()
        {
            Console.WriteLine("Added meat");
        }

        public override void addVeggies()
        {
            foreach (string v in veggieUsed)
                Console.WriteLine("Added veggies: " + v);
        }
    }
}
