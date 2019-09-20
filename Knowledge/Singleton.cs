using System;
using System.Collections.Generic;
using System.Text;

namespace Knowledge
{
    //This isn't thread-safe however, below is an example of a thread save Singleton
    public sealed class Singleton
    {
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        public void PrintDetails(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
