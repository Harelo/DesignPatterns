using System;
using Knowledge.Singleton;
using System.Collections.Generic;
using System.Text;

namespace Knowledge.Strategy
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public IGradeStrategy GradeStrategy { get; set; }

        public void PrintGrade()
        {
            GradeStrategy.PrintGradeResult();
        }
    }
}
