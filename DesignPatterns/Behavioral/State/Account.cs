using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    //This is the context
    public class Account
    {
        public Rank Rank { get; private set; }


        public string Name { get; private set; }

        public Account(string _name)
        {
            Rank = new DefaultRank();
            Name = _name;
        }

        public void HandleKick(string user)
        {
            Rank.kick(user);
        }

        public void HandleBan(string user)
        {
            Rank.ban(user);
        }

        public void HandleAddToBalance(int amount)
        {
            Rank.addToBalance(amount);
        }

        public void HandleRemoveFromBalance(int amount)
        {
            Rank.removeFromBalance(amount);
        }

        public void SetRank(Rank newRank)
        {
            this.Rank = newRank;
        }
    }
}
