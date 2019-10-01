using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class SilverPrize : Prize
    {
        public SilverPrize()
        {
            this.name = "Silver";
            this.prizeValue = 10;
        }
    }
}
