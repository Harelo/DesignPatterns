using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    class AnimalFactory
    {
        private Dictionary<string, Animal> animals = new Dictionary<string, Animal>();

        public Animal GetAnimal(string name)
        {
            Animal a = null;

            if (!animals.ContainsKey(name))
            {
                switch (name)
                {
                    case "Tiger": animals.Add("Tiger", new Tiger()); break;
                    case "Penguin": animals.Add("Penguin", new Penguin()); break;
                    case "Rhino": animals.Add("Rhino", new Rhino()); break;
                }
            }

            a = animals[name];
            return a;
        }
    }
}
