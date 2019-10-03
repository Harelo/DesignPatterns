using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public abstract class Component
    {
        protected string name;

        public Component(string _name)
        {
            this.name = _name;
        }
        
        public abstract void Display(int depth);
    }
}
