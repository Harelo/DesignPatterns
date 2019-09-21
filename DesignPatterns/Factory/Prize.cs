using System;

namespace DesignPatterns.Factory
{
    public abstract class Prize
    {

        public string name { get; set; }
        public double prizeValue { get; set; }

        public void winMessage()
        {
            Console.WriteLine("You won $" + prizeValue);
        }
    }
}
