using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public class TemplateMethodTesterProgram
    {
        public static void RunTest()
        {
            Hamburger ham1 = new DoubleCheeseBurger();
            Hamburger ham2 = new VeggieBurger();

            ham1.MakeHamburger();
            ham2.MakeHamburger();
        }
    }
}
