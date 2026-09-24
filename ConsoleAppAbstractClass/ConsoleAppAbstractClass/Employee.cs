using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstractClass
{
    //create Employee class and this class have inherit from the Person class
    public class Employee : Person
    {
        public  int Id{ get; set; }
        //create and override the SayName method
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }

    }
}
