﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Knowledge.Strategy
{
    class StrategyTesterProgram
    {
        public static void Main(string[] args)
        {
            Student newStudent = new Student() { Name = "Alex", Age = 18, Class = "Math", GradeStrategy = new AGradeStrategy() };
            newStudent.PrintGrade();
        }
    }
}
