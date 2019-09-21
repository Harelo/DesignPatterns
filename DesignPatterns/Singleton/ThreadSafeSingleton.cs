using System;

namespace DesignPatterns.Singleton
{
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = null;
        private static readonly object TheLock = new object();

        private ThreadSafeSingleton() { }

        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                //Locks these lines of code on a specific object (TheLock)
                //Makes it so only one thread can access this critical piece of code at a time
                //Only once released can another thread access it. 
                //This way we ensure the creation of only a single instance of the singleton class in a multi-threaded environment.
                lock (TheLock)
                {
                    if (instance == null)
                        instance = new ThreadSafeSingleton();
                    return instance;
                }
            }
        }

        public void PrintDetails(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
