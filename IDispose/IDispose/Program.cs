
using System;

class Program
{
    public static void Main(string[] args)
    {
        using (Car car = new Car())
        {
            car.Create();
        }
    }
}
class Car : IDisposable
{
  
    public void Create()
    {
        Console.WriteLine("Car is Created");
    }

    public void Dispose()
    {
        Console.WriteLine("The object has been disposed");
    }
}