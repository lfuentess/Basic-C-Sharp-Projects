using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMetsObjs
{
    //create class with 2 string property and 1 method 
    public class Person
    {
        //declare property
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //declare method that show the fullname on the screen
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}",FirstName,LastName);
        }
    }
}
