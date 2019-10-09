using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public class ObjectStructure
    {
        private List<IAnimal> animals = new List<IAnimal>();

        public void Attach(IAnimal animal)
        {
            animals.Add(animal);
        }

        public void Detach(IAnimal animal)
        {
            animals.Remove(animal);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IAnimal animal in animals)
                animal.accept(visitor);
        }
    }
}
