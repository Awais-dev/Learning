using System;

namespace ReferenceTypes
{
    class Program
    {
        // Reference type (because of 'class')
        class SomeRef { public Int32 age; public string name; }

        static void Main()
        {
            SomeRef r1 = new SomeRef(); // Allocated in heap
            r1.name = "Simon";
            r1.age = 28; 

            ReferenceTypes(r1);

            Console.WriteLine($"Name = {r1.name}\n" + $"Age = {r1.age}");
       
        }

        static void ReferenceTypes(SomeRef someRef)
        {
            someRef.name = "Awais";
            someRef.age = 21;
        }
    }
}