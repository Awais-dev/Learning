
using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(GC.GetTotalMemory(false) );
        Test();
        Console.WriteLine(GC.GetTotalMemory(false) ); 
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