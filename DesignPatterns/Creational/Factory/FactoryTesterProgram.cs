using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class FactoryTesterProgram
    {
        public static void RunTest()
        {
            Console.WriteLine("Randomly picking prize!");
            Random rnd = new Random();
            int prizeID = rnd.Next(1, 4);
            Prize thePrize = PrizeFactory.makePrize(prizeID);

            if (thePrize != null)
                printWinMessage(thePrize);
        }

        public static void printWinMessage(Prize prize)
        {
            prize.winMessage();
        }
    }
}
