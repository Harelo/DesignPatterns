using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    class AGradeStrategy : IGradeStrategy
    {
        void IGradeStrategy.PrintGradeResult()
        {
            Console.WriteLine("Excellent work! You got an A!");
        }
    }
}
