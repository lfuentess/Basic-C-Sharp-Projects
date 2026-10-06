using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string companyName = "SoftPro LLC";
            var employeeData = new Employee("Joe Anderson");

            Console.WriteLine("Company: {0} ",companyName);
            Console.WriteLine("Employee Name: {0}", employeeData.employeeFullName);
            Console.WriteLine("Employee Id: {0}", employeeData.employeeId);

            Console.WriteLine("press [ENTER] to exit");
            Console.ReadLine();
        }
    }
}
