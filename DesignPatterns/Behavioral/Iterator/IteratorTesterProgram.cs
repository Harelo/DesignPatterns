using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public class IteratorTesterProgram
    {
        public static void RunTest()
        {
            ArrayList b = new ArrayList() { 1, 2, 3, 4 };
            IEnumerator e = b.GetEnumerator();
            e.MoveNext();
            Console.WriteLine(e.Current);

            Console.WriteLine();

            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            IIterator i = a.GetIterator();

            Console.WriteLine("Iterating ConcreteAggregate... ");

            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.WriteLine();

            ConcreteAggregate2 c = new ConcreteAggregate2();
            c[0] = "Item 1";
            c[1] = "Item 2";
            c[2] = "Item 3";
            c[3] = "Item 4";

            IIterator i2 = c.GetIterator();

            Console.WriteLine("Iterating ConcreteAggregate2...");
            object item2 = i2.First();
            while (item2 != null)
            {
                Console.WriteLine(item2);
                if (i2.CurrentIndex() == 1)
                    Console.WriteLine("Is done when index is 1? " + i2.IsDone());
                item2 = i2.Next();
            }

            Console.WriteLine("Is done when index is 3? " + i2.IsDone());
        }
    }
}
