using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public class VeggieBurger : Hamburger
    {
        string[] veggieUsed = new string[] { "Lettuce", "Tomatoes", "Onions", "Pickle" };

        protected override bool hasCheese() { return false; }

        protected override bool hasMeat() { return false; }

        public override void addCheese() { }

        public override void addMeat() { }

        public override void addVeggies()
        {
            foreach (string v in veggieUsed)
                Console.WriteLine("Added veggies: " + v);
        }
    }
}
