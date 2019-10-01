using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    //Seperated class for generating prizes
    //Provides encapsulation for generating prizes
    //Makes it easier to make changes 
    public class PrizeFactory
    {
        public static Prize makePrize(int prizeID)
        {
            Prize thePrize = null;

            switch (prizeID)
            {
                case 1:
                    thePrize = new PlatinumPrize();
                    break;
                case 2:
                    thePrize = new GoldPrize();
                    break;
                case 3:
                    thePrize = new SilverPrize();
                    break;
            }

            return thePrize;
        }

    }
}
