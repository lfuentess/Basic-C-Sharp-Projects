using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object and past initial data
            Employee employee1 = new Employee("Sample", "Student");

            //call the SayName method (inherit)
            employee1.SayName();

            //instantiated as an instance of the Employee class
            IQuittable quittableEmployee = new Employee("John", "Doe");

            //call the Quit method on the IQuittable object reference
            quittableEmployee.Quit();

            Console.ReadLine();

        }
    }
}
