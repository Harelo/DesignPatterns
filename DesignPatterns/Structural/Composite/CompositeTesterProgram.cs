using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class CompositeTesterProgram
    {
        public static void RunTest()
        {
            Composite a = new Composite("root");

            a.Add(new Leaf("Leaf A"));
            a.Add(new Leaf("Leaf B"));

            Composite b = new Composite("Composite 2");
            b.Add(new Leaf("Leaf A2"));
            b.Add(new Leaf("Leaf B2"));

            a.Add(b);

            a.Display(0);
        }
    }
}
