using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResp
{
    public class PigHandler : Handler
    {
        private Handler succesor;

        public void handleRequest(string animalName)
        {
            if (animalName == "Pig")
                Console.WriteLine("Oink oink");

            else if (succesor != null)
            {
                Console.WriteLine("Couldn't handle request, moved request to succesor");
                succesor.handleRequest(animalName);
            }
        }

        public void setSuccesor(Handler newSuccesor)
        {
            succesor = newSuccesor;
        }
    }
}
