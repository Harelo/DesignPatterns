using System;
using System.Collections.Generic;
using System.Text;

namespace Knowledge.Strategy
{
    class AGradeStrategy : IGradeStrategy
    {
        void IGradeStrategy.PrintGradeResult()
        {
            Console.WriteLine("Excellent work! You got an A!");
        }
    }
}
