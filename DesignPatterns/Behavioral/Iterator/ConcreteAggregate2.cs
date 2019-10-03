using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public class ConcreteAggregate2 : IAggregate
    {
        List<string> list = new List<string>();
        public object this[int itemIndex]
        {
            get
            {
                if (itemIndex < list.Count)
                    return list[itemIndex];
                else return null;
            }
            set => list.Add(value.ToString());
        }

        public int Count => list.Count;

        public IIterator GetIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
