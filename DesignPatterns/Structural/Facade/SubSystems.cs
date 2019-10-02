using System;

namespace DesignPatterns.Facade
{
    public class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("MethodOne Called");
        }
    }

    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo called");
        }
    }

    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("MethodThree called");
        }
    }

    public class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("MethodFour called");
        }
    }
}
