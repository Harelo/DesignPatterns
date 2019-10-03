using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public class ConcreteAggregate : IAggregate
    {
        private ArrayList items = new ArrayList();

        public object this[int itemIndex]
        {
            get
            {
                if (itemIndex < items.Count)
                    return items[itemIndex];
                else return null;
            }

            set => items.Add(value);
        }

        public int Count => items.Count;

        public IIterator GetIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
