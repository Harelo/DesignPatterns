using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public abstract class ToppingDecorator : Pizza
    {
        protected Pizza tempPizza;

        public ToppingDecorator(Pizza _tempPizza)
        {
            this.tempPizza = _tempPizza;
        }

        public virtual double GetCost()
        {
            return tempPizza.GetCost();
        }

        public virtual string GetDescription()
        {
            return tempPizza.GetDescription();
        }
    }
}
