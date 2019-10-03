using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public class ConcreteIterator : IIterator
    {
        private IAggregate aggregate = null;
        private int current = 0;

        public ConcreteIterator(IAggregate _aggregate)
        {
            aggregate = _aggregate;
        }

        public object CurrentItem()
        {
            return aggregate[current];
        }

        public object First()
        {
            return aggregate[0];
         }

        public object IsDone()
        {
            return current >= aggregate.Count - 1;
        }

        public object Next()
        {
            object returnValue = null;

            if (current < aggregate.Count - 1)
                returnValue = aggregate[++current];

            return returnValue;

        }

        public int CurrentIndex() => current;
    }
}
