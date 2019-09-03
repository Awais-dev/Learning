using System;

namespace ValueTypes
{
    class Program
    {
        // Value type (because of 'struct')
        public struct SomeVal { public Int32 x; public string name; }
        static void Main()
        {

            SomeVal v1 = new SomeVal(); // Allocated on stack

            v1.x = 5; // Changed on stack
            v1.name = "Value";

            Console.WriteLine(v1.x); // Also displays "5"
            Console.WriteLine(v1.name); // also displays "Value"

            SomeVal v2 = v1; // Allocate on stack & copies members

            v1.x = 9; // Changes v1.x, not v2.x
            v1.name = "Value Type"; // Changes v1.x, not v2.x

            Console.WriteLine(v1.x); // Displays "9"
            Console.WriteLine(v2.x); // Displays "5"
            Console.WriteLine(v1.name); // Displays "Value Type"
            Console.WriteLine(v2.name); // Displays "Value"
        }
    }
}