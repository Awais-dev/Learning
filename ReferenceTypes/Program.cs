using System;

namespace ReferenceTypes
{
    class Program
    {
        // Reference type (because of 'class')
        class SomeRef { public Int32 x; public string name; }

        static void Main()
        {
            SomeRef r1 = new SomeRef(); // Allocated in heap

            r1.x = 5; // Pointer dereference
            r1.name = "Reference";

            Console.WriteLine(r1.x); // Displays "5"
            Console.WriteLine(r1.name); // also displays "Reference"

            SomeRef r2 = r1; // Copies reference (pointer) only

            r1.x = 8; // Changes r1.x and r2.x
            r1.name = "Reference Type";// Changes r1.x and r2.x

            Console.WriteLine(r1.x); // Displays "8"
            Console.WriteLine(r2.x); // Displays "8"
            Console.WriteLine(r1.name); // Displays "Reference Type"
            Console.WriteLine(r2.name); // Displays "Reference Type"

        }
    }
}