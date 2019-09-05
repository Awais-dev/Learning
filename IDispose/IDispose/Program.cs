
using System;
using System.Diagnostics;

public class ExampleClass
{
    Stopwatch sw;

    public ExampleClass()
    {
        sw = Stopwatch.StartNew();
        Console.WriteLine("Instantiated object");
    }

    public void ShowDuration()
    {
        Console.WriteLine("This instance of {0} has been in existence for {1}",
                          this, sw.Elapsed);
    }

    ~ExampleClass()
    {
        Console.WriteLine("Finalizing object");
        sw.Stop();
        Console.WriteLine("This instance of {0} has been in existence for {1}",
                          this, sw.Elapsed);
        
    }
}

public class Program
{
    public static void Main()
    {
        ExampleClass ex = new ExampleClass();
        ex.ShowDuration();
    }
}
// The example displays output like the following:
//    Instantiated object
//    This instance of ExampleClass has been in existence for 00:00:00.0011060
//    Finalizing object
//    This instance of ExampleClass has been in existence for 00:00:00.0036294
//using System;
//class Program
//{
//    public static void Main(string[] args)
//    {
//        Test();


//    }
//    public static void Test()
//    {
//        Car car = new Car();
//        car.Create();
//        car.Dispose();
//    }
//}
//class Car : IDisposable
//{
//    bool disposed = false;

//    // Public implementation of Dispose pattern callable by consumers.
//    public void Dispose()
//    {
//        Dispose(true);
//        GC.SuppressFinalize(this);
//    }

//    // Protected implementation of Dispose pattern.
//    protected virtual void Dispose(bool disposing)
//    {
//        if (disposed)
//            return;

//        if (disposing)
//        {
//            // Free any other managed objects here.
//            //
//        }

//        // Free any unmanaged objects here.
//        //
//        disposed = true;
//    }

//    public void Create()
//    {
//        Console.WriteLine("Car is Created");
//    }

//    ~Car()
//    {
//        Dispose(false);
//        Console.WriteLine("Car instance is destroyed");
//    }
//}