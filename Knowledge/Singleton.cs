using System;
using System.Collections.Generic;
using System.Text;

namespace Knowledge
{
    //A class that should only have one instance.
    //An example for usage for this is to use a class like this as a scrabble game manager
    //This class needs to be sealed because if for example we created a nested derived class
    //we will be able to instantiate another instance of Singleton, and by that, this class will no longer BE a singleton class
    //This class isn't thread-safe, an example of a thread-safe singleton can be found within the file ThreadSafeSingleton.cs
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
