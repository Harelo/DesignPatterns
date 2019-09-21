using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class PlatinumPrize : Prize
    {
        public PlatinumPrize()
        {
            this.name = "Platinum";
            this.prizeValue = 100;
        }
    }
}
