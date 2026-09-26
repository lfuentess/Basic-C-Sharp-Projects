using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorsoverload
{
    //Create Employee class
    public class Employee
    {
        //add properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Employee constructor
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        //== operator overload 
        public static bool operator == (Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }
        //!= operator overload
        public static bool operator != (Employee emp1, Employee emp2)
        {
             return !(emp1.Id != emp2.Id);
        }
        // messsage method show the result
        public static void message(bool dataIn)
        {
            if (dataIn)
            {
                Console.WriteLine("Result: The Id employees are Equal.");
            }
            
            if (!dataIn)
            {
                Console.WriteLine("Result: The Id employees are Not equal.");
            }
        }
    }
}
