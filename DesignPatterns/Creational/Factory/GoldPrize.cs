using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class GoldPrize : Prize
    {
        public GoldPrize()
        {
            this.name = "Gold";
            this.prizeValue = 50;
        }
    }
}
