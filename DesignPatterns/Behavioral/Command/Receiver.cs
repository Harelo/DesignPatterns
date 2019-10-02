using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
}
