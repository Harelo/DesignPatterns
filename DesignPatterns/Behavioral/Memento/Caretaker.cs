using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class Caretaker
    {
        public List<Memento> mementos;
        public Caretaker() => mementos = new List<Memento>();
        public void addMemento(Memento m) => mementos.Add(m);
        public Memento getMemento(int index) => mementos[index];
    }
}
