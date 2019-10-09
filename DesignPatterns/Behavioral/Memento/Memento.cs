using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class Memento
    {
        public string state { get; }
        public Memento(string _state) => state = _state;
    }
}
