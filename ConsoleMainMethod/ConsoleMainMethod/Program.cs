using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMainMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Main Method
            //Instantiate commethods class
            commethods cmenthod = new commethods();

            Console.WriteLine("4 * 3 = {0} ", cmenthod.multiplication(4));// call int multiplication method 
            Console.WriteLine("4.25 * 3 = {0} ", cmenthod.multiplication(4.25));// call decimal multiplication method
            Console.WriteLine("'45' * 2 = {0} ", cmenthod.multiplication("45"));// call string multiplication method 

        }
    }
}
