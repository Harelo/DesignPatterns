using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResp
{
    public interface Handler
    {
        void setSuccesor(Handler newSuccesor);
        void handleRequest(string animalName);
    }
}
