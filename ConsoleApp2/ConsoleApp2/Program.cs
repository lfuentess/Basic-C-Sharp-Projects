using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Strings and Integers 

            //instantion of integer list
            List<Int64> numbers = new List<Int64>()
            { 4,9,10,6,20,24,48,64,168 };
            bool ctrlloop = false;

            //loop control 
            while (!ctrlloop) 
            {
                // begin try/catch
                try
                {
                    Console.WriteLine("Entry a number, please");
                    Int64 divi = Convert.ToInt64(Console.ReadLine());
                    // show all number divided for user number
                    foreach (Int64 num in numbers)
                    {
                        Console.WriteLine(num + " divide by " + divi + " equal " + (num / divi) + " \n");
                    }
                    ctrlloop = true;
                }
                // all the exceptions that could occur and message to the user.
                catch (FormatException)// if the user type string
                {
                    Console.WriteLine("Please, only type numbers.");
                }
                catch(DivideByZeroException) // if the user type number 0
                {
                    Console.WriteLine("Please, type distinct number of 0");
                }
                catch (Exception) // any another error possible 
                {
                    Console.WriteLine("Please, check the value inserted.");
                }
                finally
                {
                    if (!ctrlloop)
                        Console.WriteLine("Continue... \n");
                }
            }
            //final message 
            Console.WriteLine("exit to try/catch block.");
            Console.WriteLine("The 'app' is finished.");
            Console.ReadLine();
        }
    }
}
