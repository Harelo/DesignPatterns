using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class DecoratorTesterProgram
    {
        public static void Main(string[] args)
        { 
            Pizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            Console.WriteLine(basicPizza.GetDescription());
            Console.WriteLine(basicPizza.GetCost());
        }
    }
}
