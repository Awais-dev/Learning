using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
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
}
