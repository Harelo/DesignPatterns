using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class MementoTesterProgram
    {
        public static void RunTest()
        {
            //Create an originator which creates and gets mementos
            Originator o = new Originator();

            //Set state to On for the originator
            o.state = "On";

            Console.WriteLine("Current state: " + o.state);

            Caretaker c = new Caretaker();
            c.addMemento(o.createMemento());

            o.state = "Off";

            Console.WriteLine("Current state: " + o.state);

            //Stores the snapshot
            o.setMemento(c.getMemento(0));

            Console.WriteLine("Current state: " + o.state);
        }
    }
}
