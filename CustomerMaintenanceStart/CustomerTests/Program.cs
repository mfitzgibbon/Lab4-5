using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerConstuctors();
        }

        static void TestCustomerConstuctors()
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer("Test", "Testerson", "test@email.com");

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor. Expecting default values. " + c1.GetDisplayText("\t"));
            Console.WriteLine("Test constructor. Expecting test values. " + c2.GetDisplayText("\t"));

            Console.ReadLine();
        }
    }
}
