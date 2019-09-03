using System;

namespace MemoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e;
            Int32 year;
            e = new Manager();
            e = Employee.Lookup("Joe");
            year = e.GetYearsEmployed();
            e.GetProgressReport();
        }
    }

   internal class Employee
    {
        public Int32  GetYearsEmployed()
        {
            return GetYearsEmployed();
        }
        public virtual String GetProgressReport()
        {
            return GetProgressReport();
        }
        public static Employee Lookup(String name)
        {
            return Lookup(name);
        }
    }

   internal class Manager : Employee
    {
        public override String GetProgressReport()
        {
            return GetProgressReport();
        }
    }
}
