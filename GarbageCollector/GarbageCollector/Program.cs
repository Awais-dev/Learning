using System;
class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Total memory: " + GC.GetTotalMemory(true));

        Car car = new Car();
        car.Test();
        car.make = "Seat";

        //Console.WriteLine("Totalmemoryafterobject: " + GC.GetTotalMemory(true));

        Console.WriteLine($"GC Generation for object: { GC.GetGeneration(car)}");

        Console.WriteLine("Count for Gen 0: " + GC.CollectionCount(0));
        Console.WriteLine("Count for Gen 1: " + GC.CollectionCount(1));
        Console.WriteLine("Count for Gen 2: " + GC.CollectionCount(2));

        GC.Collect(0);
        Console.WriteLine("GC Count after Forcecollect: " + GC.CollectionCount(0));
    }
}

class Car
{
    public string make { get; set; }

    public string Test()
    {
        return "Test";
    }

    ~ Car()
    {
        
    }
}