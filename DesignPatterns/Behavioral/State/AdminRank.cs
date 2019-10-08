using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class AdminRank : Rank
    {
        public int virtualCoins { get; private set; }
        public string rankName { get; private set; }

        public AdminRank()
        {
            rankName = "Admin";
            virtualCoins = 100000;
        }

        public void addToBalance(int amount)
        {
            virtualCoins += amount;
            Console.WriteLine($"{amount} coins added");
            printBalance();
        }

        public void removeFromBalance(int amount)
        {
            if (virtualCoins - amount >= 0)
            {
                virtualCoins -= amount;
                Console.WriteLine($"{amount} was removed from your coins");
                printBalance();
            }
            else
                Console.WriteLine("Not enough money to remove that amount");
        }

        public void ban(string user)
        {
            Console.WriteLine($"Banned {user}");
        }

        public void kick(string user)
        {
            Console.WriteLine($"Kicked {user}");
        }

        public void printBalance()
        {
            Console.WriteLine($"Your balance is now: {virtualCoins}");
        }
    }
}
