using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object and initialize 
            Employee nEmployee = new Employee() { firstName = "Sample", lastName = "Student" };

            //call the SayName method
            nEmployee.SayName();

            Console.ReadLine();
        }
    }
}
