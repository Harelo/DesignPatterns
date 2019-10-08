using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    class Tiger : Animal
    {
        public Tiger()
        {
            this.Name = "Tiger";
            this.Age = 5;
        }

        public override void DisplayAmount(int amount)
        {
            Console.WriteLine("Tigers amount: " + amount);
        }
    }

    class Penguin : Animal
    {
        public Penguin()
        {
            this.Name = "Penguin";
            this.Age = 3;
        }

        public override void DisplayAmount(int amount)
        {
            Console.WriteLine("Penguins amount: " + amount); 
        }
    }

    class Rhino : Animal
    {
        public Rhino()
        {
            this.Name = "Rhino";
            this.Age = 10;
        }

        public override void DisplayAmount(int amount)
        {
            Console.WriteLine("Rhinos amount: " + amount);
        }
    }
}
