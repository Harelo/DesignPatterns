using System;
using System.Collections;

namespace DesignPatterns.Iterator
{
    //This is basically like IEnumerator
    public interface IIterator
    {
        object First();
        object Next();
        object IsDone();
        object CurrentItem();
        int CurrentIndex();
    }
}
