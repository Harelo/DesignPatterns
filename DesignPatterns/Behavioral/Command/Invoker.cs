using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class Invoker
    {
        private Command command;

        public void SetCommand(Command _command)
        {
            this.command = _command;
        }

        public void ExecuteCommand()
        {
            this.command.Execute();
        }
    }
}
