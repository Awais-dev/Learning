using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            bool input = false;
            int number;
            while (!input)
            {
                try
                {

                    Console.WriteLine("Enter a number");
                    number = Convert.ToInt32(Console.ReadLine());
                    input = true;
                }
                catch
                {
                    Console.WriteLine("Error Caught, Please enter a number\n");
                }
                finally
                {
                    if (input == true)
                    {
                        Console.WriteLine("App closed");
                    }
                }
            }

        }
    }
}
