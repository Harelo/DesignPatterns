using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class MakeSoundVisitor : IVisitor
    {
        public void visit(Cat cat)
        {
            Console.WriteLine($"Cat {cat.name} : Meow");
        }

        public void visit(Dog dog)
        {
            Console.WriteLine($"Dog {dog.name} : Woof");
        }

        public void visit(Cow cow)
        {
            Console.WriteLine($"Cow {cow.name} : Moo");
        }
    }
}
