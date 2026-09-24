using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePolymorphism
{
    //Employee class that inherit from Person and IQuittable interface
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //constructor to initialize properties
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        //Implementation of the abstract method SayName() of the Person class
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1} \n", FirstName, LastName);
        }
        //Implementation of the Quit() method of the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Employee Name: {0} {1} \n", FirstName, LastName);
        }
    }
}
