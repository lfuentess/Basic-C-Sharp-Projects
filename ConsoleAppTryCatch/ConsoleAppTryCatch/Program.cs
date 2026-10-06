using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // intantiate the class and ask age from the user and show message with the year of born
            var calcAge = new CalcAge();
            try
            {
                Console.WriteLine("What is your age?");
                string dataOut = calcAge.AskAge();
                Console.WriteLine("You born in the {0} year.", dataOut);
            }
            // catch some errors or exceptions and show message about the error.
            catch (FraudException)
            {
                Console.WriteLine("You try to fail the system. Please contact your Sytem Administrator.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your Sytem Administrator.");
            }
            Console.ReadLine();
        }
    }
}
