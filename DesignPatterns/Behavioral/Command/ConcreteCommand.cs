using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class ConcreteCommand : Command
    {
        protected Receiver receiver;

        public ConcreteCommand(Receiver _receiver)
        {
            this.receiver = _receiver;
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}
