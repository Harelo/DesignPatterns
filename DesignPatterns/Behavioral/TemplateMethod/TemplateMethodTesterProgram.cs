using System.Collections.Generic;

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
