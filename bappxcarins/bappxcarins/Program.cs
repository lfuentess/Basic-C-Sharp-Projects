using System;

namespace bappxcarins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Approval program for Car Insurance \n");//show identified application program
            /* show question and recive answer*/
            Console.WriteLine("What is your age?"); 
            int iAge = Convert.ToInt32(Console.ReadLine()); //set integer variable and convert string data to integer data
            Console.WriteLine("Have you ever had a DUI?");
            bool bDUI = Convert.ToBoolean(Console.ReadLine());//set boolean variable and convert string data to boolean data
            Console.WriteLine("How many speeding tickets do you have?");
            int iTickets = Convert.ToInt32(Console.ReadLine());//set integer variable and convert string data to integer data

            bool bQualified = false; //set variable of approval or denied car insurance
            bQualified = (bDUI == false && iAge > 15 && iTickets < 4);// evaluate all data is agree with approval and assign value

            Console.WriteLine("Qualified for insurance? \n" + bQualified.ToString());//show the result of evaluation of data 
            Console.Read();
        }
    }
}
