using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iNum=20; // define int variable and assign value
            while (iNum >0) // set loop and condition to keep inside
            {
                Console.WriteLine("counting: " + iNum.ToString()); // show message and variable value 
                iNum--; // reduce value variable
            }
            Console.WriteLine("counting finished"); // show message 

            do // set another loop 
            {
                Console.WriteLine("counting (again): " + iNum.ToString()); // show message and variable value 
                iNum++; // increse value variable
            } while (iNum <= 20); // condition to do until

            Console.WriteLine("counting finished");// show message 
        }
    }
}
