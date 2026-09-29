using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a list of at least 10 employees. At least two employees should have the first name “Joe”.
            List<Employee> listEmployee = new List<Employee>()
            {   
                new Employee() { Id = 1,FirstName = "John",LastName = "Smith" },
                new Employee() { Id = 2,FirstName = "Greg",LastName = "Thompson" },
                new Employee() { Id = 3,FirstName = "Joe",LastName = "Beaver" },
                new Employee() { Id = 4,FirstName = "Maria",LastName = "Stevenson" },
                new Employee() { Id = 5,FirstName = "Paul",LastName = "Benson" },
                new Employee() { Id = 6,FirstName = "Caroline",LastName = "Perry" },
                new Employee() { Id = 7,FirstName = "Gabriel",LastName = "Thorpe" },
                new Employee() { Id = 8,FirstName = "Joe",LastName = "Coocker" },
                new Employee() { Id = 9,FirstName = "Greta",LastName = "Potter" },
                new Employee() { Id =10,FirstName = "George",LastName = "Davison" }
            };
            
            //create a new list of all employees with the first name “Joe”.
            List<Employee> joesEmployees = new List<Employee>();
            foreach (Employee employee in listEmployee)
            {
                if (employee.FirstName == "Joe")
                {
                    joesEmployees.Add(employee);
                }
            }

            //the same action again, but this time with a lambda expression.
            List<Employee> joeEmployeeLambda = listEmployee.Where(x => x.FirstName == "Joe").ToList();
            
            //make a list of all employees with an Id number greater than 5.
            List<Employee> employees = listEmployee.Where(x => x.Id > 5).ToList();

            //message to show or not the result of the process
            Console.WriteLine("Process terminated. \n");
            Console.WriteLine("Do you want to see the results of the process (Y or N)");
            string iWantSee = Console.ReadLine().ToString().ToLower();
            if (iWantSee == "y")
            { 
                foreach (Employee employee in joesEmployees)
                {
                    Console.WriteLine("Employee: {0} {1} {2}",employee.Id,employee.FirstName,employee.LastName);
                }
                Console.WriteLine("-----------------------------------------------------------");
                foreach (Employee employee in joeEmployeeLambda)
                {
                    Console.WriteLine("Employee: {0} {1} {2}", employee.Id, employee.FirstName, employee.LastName);
                }
                Console.WriteLine("-----------------------------------------------------------");
                foreach (Employee employee in employees)
                {
                    Console.WriteLine("Employee: {0} {1} {2}", employee.Id, employee.FirstName, employee.LastName);
                }
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
