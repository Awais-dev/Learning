using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.Move();
            Ford.Stop();
            Ford.Fuel();

            Electric Prius = new Electric();
            Prius.Move();
            Prius.Stop();
            Prius.Fuel();
            Prius.Charge();
        }
    }

    interface IVehicle
    {
        void Move();
        void Stop();
        void Fuel();
    }

    interface IHybrid
    {
        void Charge();
    }

    public class Car : IVehicle
    {

        public void Move()
        {
            Console.WriteLine("The Car is Moving");
        }
        public void Stop()
        {
            Console.WriteLine("The Car is Stopping");
        }

        public void Fuel()
        {
            Console.WriteLine("The car is Fueling");
        }
    }
    public class Electric : IVehicle, IHybrid
    {
        public void Move()
        {
            Console.WriteLine("The Hybrid Car is Moving");
        }

        public void Stop()
        {
            Console.WriteLine("The Hybrid Car is Stopping");
        }

        public void Fuel()
        {
            Console.WriteLine("The Hybrid car is Fueling");
        }

        public void Charge()
        {
            Console.WriteLine("The Hybrid Car is Charging");
        }
    }
}