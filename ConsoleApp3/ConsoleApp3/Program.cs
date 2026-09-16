using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling Methods
            
            //create math object 
            Math math = new Math();
            
            //require from user a number to perform operatios
            Console.WriteLine("Enter a number to perform mathematical operations.");
            int valEntry = Convert.ToInt32(Console.ReadLine());

            //calls each methods send int value and return result value to integer 
            int result0 = math.Sum(valEntry);
            int result1 = math.Sub(valEntry);
            int result2 = math.Mul(valEntry);

            //show each operations performed with the result 
            Console.WriteLine(valEntry + " +  5 = " +result0);
            Console.WriteLine(valEntry + " - 10 = " + result1);
            Console.WriteLine(valEntry + " *  6 = " + result2);

            Console.ReadLine();
        }
    }
}
