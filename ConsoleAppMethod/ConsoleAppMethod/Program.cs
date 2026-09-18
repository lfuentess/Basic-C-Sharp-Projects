using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method
            //instantation class
            MathMethod mathMethod = new MathMethod();

            //require from user first number
            Console.WriteLine("Enter a number, please");
            int valueA = Convert.ToInt32(Console.ReadLine());
            try
            {
                //require from user second number, but isn't requerid
                Console.WriteLine("Enter other number, (this number isn't requerid)");
                int valueB = Convert.ToInt32(Console.ReadLine());
                //call method with 2 parameters
                Console.WriteLine(valueA + " * " + valueB +" = "+  mathMethod.MathOperation(valueA, valueB));
            }
            catch {
                //call method with only the first parameter
                Console.WriteLine(valueA + " * 2 (value x default) = " + mathMethod.MathOperation(valueA));
            }
        }
    }
}
