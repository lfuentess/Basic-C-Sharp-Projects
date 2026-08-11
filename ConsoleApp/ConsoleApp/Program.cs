using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number: "); //Request a number from a user
            double dNumberA = double.Parse(Console.ReadLine()); //read number and assign to dNumberA variable
            double dresult0 = dNumberA * 50;// multiply dNumberA by 50 and assign to dresult0 
            Console.WriteLine("The multiplication result is: " + dresult0.ToString());//show message and result of operation, the result is convert to string

            Console.WriteLine("Insert a number: ");//Request a number from a user
            double dNumberB = double.Parse(Console.ReadLine());//read number and assign to dNumberB variable
            double dresult1 = dNumberB + 25;// add dNumberB plus 25 and assign to dresult1 
            Console.WriteLine("The addition result is: " + dresult1.ToString());//show message and result of operation, the result is convert to string

            Console.WriteLine("Insert a number: ");//Request a number from a user
            double dNumberC = double.Parse(Console.ReadLine());//read number and assign to dNumberC variable
            double dresult2 = dNumberC /12.5;// divide dNumberC by 12.5 and assign to dresult2 
            Console.WriteLine("The division result is: " + dresult2.ToString());//show message and result of operation, the result is convert to string

            Console.WriteLine("Insert a number: ");//Request a number from a user
            double dNumberD = double.Parse(Console.ReadLine());//read number and assign to dNumberD variable
            bool bresult3 = dNumberD > 50;// multiply dNumberA by 50 and assign to dresult3
            Console.WriteLine("The number is > 50 : " + bresult3.ToString());//show message and result of operation, the result is convert to string

            Console.WriteLine("Insert a number: ");//Request a number from a user
            double dNumberE = double.Parse(Console.ReadLine());//read number and assign to dNumberE variable
            double dresult4 = dNumberE % 7;// multiply dNumberA by 50 and assign to dresult4
            Console.WriteLine("The remaider is: " + dresult4.ToString());//show message and result of operation, the result is convert to string

        }
    }
}
