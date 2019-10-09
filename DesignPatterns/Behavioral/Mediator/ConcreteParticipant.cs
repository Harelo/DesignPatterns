using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    //This is our concrete colleague
    public class ConcreteParticipant : Participant
    {
        public ConcreteParticipant(string _name) : base(_name) { }
    }
}
