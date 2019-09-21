using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class FactoryTesterProgram
    {
        public static void RunTest()
        {
            Prize thePrize = PrizeFactory.makePrize();

            if (thePrize != null)
                printWinMessage(thePrize);
        }

        public static void printWinMessage(Prize prize)
        {
            prize.winMessage();
        }
    }
}
