using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton myInstance = Singleton.Instance();
            Singleton myInstance2 = Singleton.Instance();

        }
    }

    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {
            Console.WriteLine("Instance 1 created");
        }

        public static Singleton Instance()
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }

    }
}
