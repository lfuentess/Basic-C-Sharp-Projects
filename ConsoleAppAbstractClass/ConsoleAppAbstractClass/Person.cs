using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstractClass
{
    //Create an abstract class Person
    public abstract class Person
    {
        //create two propertiers
        public string firstName { get; set; }
        public string lastName { get; set; }

        //create an abstract method 
        public abstract void SayName();
        
    }
}
