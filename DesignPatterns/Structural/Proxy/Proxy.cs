using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    class Proxy : Subject
    {
        private Subject realSubject;

        public override void Request()
        {
            if(realSubject == null)
            {
                realSubject = new RealSubject();
            }

            realSubject.Request();
        }
    }
}
