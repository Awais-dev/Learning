
using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Available memory before instance is destroyed: {GC.GetTotalMemory(true)}");
        Test();

        GC.Collect();
        Console.WriteLine($"Available memory after instance is destroyed: { GC.GetTotalMemory(true)}");
    

    }

    public static void Test()
    {
        Car car = new Car();
        car.Create();
    }
}

class Car
{
    public void Create()
    {
        Console.WriteLine("Car is Created");
    }

    ~Car()
    {
        Console.WriteLine("Car instance is destroyed");
    }
}