using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResp
{
    public class ChainOfRespTesterProgram
    {
        public static void RunTest()
        {
            PigHandler pigHandler = new PigHandler();
            CowHandler cowHandler = new CowHandler();
            DogHandler dogHandler = new DogHandler();

            pigHandler.setSuccesor(cowHandler);
            cowHandler.setSuccesor(dogHandler);

            pigHandler.handleRequest("Dog");
        }
    }
}
