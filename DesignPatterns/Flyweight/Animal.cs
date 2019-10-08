using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    abstract class Animal
    {
        //Intrinsic state
        protected string Name;
        protected int Age;

        public abstract void DisplayAmount(int amount);
    }
}
