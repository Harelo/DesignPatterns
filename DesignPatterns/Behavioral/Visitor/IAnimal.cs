using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    //Our Element
    public interface IAnimal
    {
        string name { get; set; }
        void accept(IVisitor visitor);
    }
}
