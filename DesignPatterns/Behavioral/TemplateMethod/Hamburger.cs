using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public abstract class Hamburger
    {
        //The template method
        public void MakeHamburger()
        {
            putBun();

            if (hasMeat())
                addMeat();

            if (hasCheese())
                addCheese();

            if (hasVeggies())
                addVeggies();

            wrapSandwich();
        }

        public void putBun()
        {
            Console.WriteLine("Bun put");
        }

        public void wrapSandwich()
        {
            Console.WriteLine("Wrapped sandwich");
        }

        public abstract void addMeat();
        public abstract void addCheese();
        public abstract void addVeggies();

        // These are called hooks
        // If the user wants to override these they can
        protected virtual bool hasCheese() { return true; }
        protected virtual bool hasMeat() { return true; }
        protected virtual bool hasVeggies() { return true; }

    }
}
