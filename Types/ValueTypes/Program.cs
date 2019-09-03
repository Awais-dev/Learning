using System;

namespace ValueTypes
{
    class Program
    {
        // Reference type (because of 'class')
        class SomeRef { public Int32 x; public string name; }

        // Value type (because of 'struct')
        public struct SomeVal { public Int32 x; public string name; }
        static void Main()
        {
            SomeRef r1 = new SomeRef(); // Allocated in heap
            SomeVal v1 = new SomeVal(); // Allocated on stack

            r1.x = 5; // Pointer dereference
            r1.name = "Reference";
            v1.x = 5; // Changed on stack
            v1.name = "Value";

            Console.WriteLine(r1.x); // Displays "5"
            Console.WriteLine(r1.name); // also displays "Reference"
            Console.WriteLine(v1.x); // Also displays "5"
            Console.WriteLine(v1.name); // also displays "Value"

            SomeRef r2 = r1; // Copies reference (pointer) only
            SomeVal v2 = v1; // Allocate on stack & copies members

            r1.x = 8; // Changes r1.x and r2.x
            v1.x = 9; // Changes v1.x, not v2.x
            v1.name = "Value Type"; // Changes v1.x, not v2.x
            r1.name = "Reference Type";// Changes r1.x and r2.x

            Console.WriteLine(r1.x); // Displays "8"
            Console.WriteLine(r2.x); // Displays "8"
            Console.WriteLine(v1.x); // Displays "9"
            Console.WriteLine(v2.x); // Displays "5"
            Console.WriteLine(v1.name); // Displays "Value Type"
            Console.WriteLine(v2.name); // Displays "Value"
            Console.WriteLine(r1.name); // Displays "Reference Type"
            Console.WriteLine(r2.name); // Displays "Reference Type"


        }
    }
}