using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMetsObjs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and initialize
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student" };
            //call method
            employee1.SayName();
            Console.ReadLine();
        }
    }
}