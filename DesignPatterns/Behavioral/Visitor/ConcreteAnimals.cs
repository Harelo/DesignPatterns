using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class Cat : IAnimal
    {
        public string name { get; set; }

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }

    public class Dog : IAnimal
    {
        public string name { get; set; }

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }

    public class Cow : IAnimal
    {
        public string name { get; set; }

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
