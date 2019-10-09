using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class Originator
    {
        public string state { get; set; }   
        public Memento createMemento() => new Memento(state);
        public void setMemento(Memento memento) => state = memento.state;

    }
}
