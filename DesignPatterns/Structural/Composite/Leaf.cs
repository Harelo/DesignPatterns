using System;

namespace DesignPatterns.Composite
{
    public class Leaf : Component
    {
        public Leaf(string _name) : base(_name) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
