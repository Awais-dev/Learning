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
}