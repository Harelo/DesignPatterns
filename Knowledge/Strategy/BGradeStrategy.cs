using System;
using System.Collections.Generic;
using System.Text;

namespace Knowledge.Strategy
{
    class BGradeStrategy : IGradeStrategy
    {
        void IGradeStrategy.PrintGradeResult()
        {
            Console.WriteLine("Not too bad, you got a B!");
        }
    }
}
