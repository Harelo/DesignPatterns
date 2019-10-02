using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class CommandTesterProgram
    {
        public static void RunTest()
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
