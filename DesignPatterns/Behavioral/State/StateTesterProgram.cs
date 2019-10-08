using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class StateTesterProgram
    {
        public static void RunTest()
        {
            Account account = new Account("John");
            account.HandleKick("Max");
            account.HandleBan("Max");
            account.HandleAddToBalance(500);
            account.HandleRemoveFromBalance(500);

            account.SetRank(new AdminRank());
            Console.WriteLine();

            account.HandleKick("Max");
            account.HandleBan("Max");
            account.HandleAddToBalance(500);
            account.HandleRemoveFromBalance(500);;
        }
    }
}
