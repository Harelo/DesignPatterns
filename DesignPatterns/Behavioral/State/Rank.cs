using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    //A "state" interface
    public interface Rank
    {
        int virtualCoins { get; }
        string rankName { get; }

        void ban(string user);

        void kick(string user);

        void addToBalance(int amount);

        void removeFromBalance(int amount);

        void printBalance();
    }
}
