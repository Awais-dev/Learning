using System;

namespace SealedMethods
{
    abstract class Greeting
    {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }

        public virtual void Bye()
        {
            Console.WriteLine("bye");
        }
    }

    sealed class Person : Greeting
    {
        public void Test()
        {
            Hello();
        }

        public override void Bye()
        {
            Console.WriteLine("See you later");
        }

    }

    //class cat : Person
    //{

      
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Person awais = new Person();
            awais.Test();
            awais.Bye();

        }
    }
}
