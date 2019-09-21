using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    class BGradeStrategy : IGradeStrategy
    {
        void IGradeStrategy.PrintGradeResult()
        {
            Console.WriteLine("Not too bad, you got a B!");
        }
    }
}
