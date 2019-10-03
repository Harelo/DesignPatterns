using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string _name) : base(_name) { }

        public void Add(Component c)
        {
            children.Add(c);
        }

        public void Remove(Component c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component c in children)
                c.Display(depth + 2);
        }


    }
}
