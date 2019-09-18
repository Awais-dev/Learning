using System;

namespace SealedMethods
{
    abstract class Greeting
    {
        public abstract void Hello();
        

        public virtual void Bye()
        {
            Console.WriteLine("bye");
        }
    }

    sealed class Person : Greeting
    {
        public override void Hello()
        {
            Console.WriteLine("Hello there");
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
            awais.Hello();
            awais.Bye();

        }
    }
}
