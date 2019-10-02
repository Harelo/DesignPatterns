using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class FacadeTesterProgram
    {
        public static void RunTest()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
        }
    }
}
