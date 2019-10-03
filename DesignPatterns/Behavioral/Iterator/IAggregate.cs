using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    //This is basically like IEnumerable
    public interface IAggregate
    {
        IIterator GetIterator();
        object this[int itemIndex] { set; get; }
        int Count { get; }
    }
}
