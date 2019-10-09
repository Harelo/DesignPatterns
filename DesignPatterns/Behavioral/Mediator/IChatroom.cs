using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    //This is our mediator
    public interface IChatroom
    {
        void Register(Participant p);

        void Send(Participant from, Participant to, string message);
    }
}
