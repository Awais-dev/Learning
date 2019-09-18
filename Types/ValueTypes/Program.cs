using System;

namespace ValueTypes
{
    class Program
    {
        // Value type (because of 'struct')
        public struct SomeVal { public Int32 Age; public string Name; }
        static void Main()
        {

            SomeVal v1 = new SomeVal(); // Allocated on stack

            v1.Age = 28; // Changed on stack
            v1.Name = "Simon";

            ValueTypes(v1);

            Console.WriteLine($"Name = {v1.Name}\n" + $"Age = {v1.Age}");

        }

        static void ValueTypes(SomeVal someVal)
        {
            someVal.Age = 21;
            someVal.Name = "Awais";

        }
    }
}