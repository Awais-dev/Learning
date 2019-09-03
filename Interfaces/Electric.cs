using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
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
