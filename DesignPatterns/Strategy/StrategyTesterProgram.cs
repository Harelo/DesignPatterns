using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    class StrategyTesterProgram
    {
        public static void RunTest()
        {
            Student newStudent = new Student() { Name = "Alex", Age = 18, Class = "Math", GradeStrategy = new BGradeStrategy() };
            newStudent.PrintGrade();
        }
    }
}
