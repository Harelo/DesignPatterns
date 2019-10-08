using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Request fullfilled");
        }
    }
}
