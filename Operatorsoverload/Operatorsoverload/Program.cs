using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorsoverload
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiation and initialization
            Employee employeeA = new Employee(15, "Joe", "Doe");
            Employee employeeB = new Employee(15, "Joe", "Smith");
            Employee employeeC = new Employee(16, "Jane", "McKey");

            //show message first comparison 
            Console.WriteLine("Id1 = {0} equal Id2 = {1} ?", employeeA.Id, employeeB.Id);

            //call == operator overload
            bool comp = employeeA == employeeB;
            //call show method the result of comparison
            Employee.message(comp);

            //show message second comparison equal
            Console.WriteLine("Id1 = {0} equal Id3 = {1} ?", employeeA.Id, employeeC.Id);
            //
            bool comp1 = employeeA != employeeC;
            //call show method the result of comparison
            Employee.message(comp1);
        }

    }
}
