﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    class FGradeStrategy : IGradeStrategy
    {
        void IGradeStrategy.PrintGradeResult()
        {
            Console.WriteLine("Oh no, you failed the class and got an F!");
        }
    }
}
