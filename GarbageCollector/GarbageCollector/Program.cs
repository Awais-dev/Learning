using System;
class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Total memory: " + GC.GetTotalMemory(true));

        car car = new car();
        car.Test();
        car.make = "Seat";

        //Console.WriteLine("Totalmemoryafterobject: " + GC.GetTotalMemory(true));

        Console.WriteLine($"GC Generation for object: { GC.GetGeneration(car)}");

        Console.WriteLine("Totalmemoryafterobject: " + GC.CollectionCount(0));
        Console.WriteLine("Totalmemoryafterobject: " + GC.CollectionCount(1));
        Console.WriteLine("Totalmemoryafterobject: " + GC.CollectionCount(2));

        GC.Collect(0);
        Console.WriteLine("GC Count after Forcecollect: " + GC.CollectionCount(0));
    }
}

class car
{
    public string make { get; set; }

    public string Test()
    {
        return "Test";
    }
}