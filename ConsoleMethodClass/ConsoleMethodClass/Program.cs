using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            methodsClass methodsClass = new methodsClass();

            //explain operation #1
            Console.WriteLine("Call the method in the class, passing in two numbers. \n");
            methodsClass.method(14, 25);

            //explain operation #2
            Console.WriteLine("Call the method in the class, specifying the parameters by name. \n");
            methodsClass.method(dataInA: 40, dataInB: 38);

            Console.ReadLine();
        }
    }
}
