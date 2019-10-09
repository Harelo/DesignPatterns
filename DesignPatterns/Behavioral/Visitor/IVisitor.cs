using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public interface IVisitor
    {
        void visit(Cat cat);
        void visit(Dog dog);
        void visit(Cow cow);
    }
}
