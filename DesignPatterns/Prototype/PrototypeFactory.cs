using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class PrototypeFactory
    {
        public AnimalPrototype getClone(AnimalPrototype animalSample) => animalSample.makeCopy();
    }
}
