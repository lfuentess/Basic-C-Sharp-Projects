using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassMethod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //instantiate the class
            Operations operations = new Operations();
            //show message to user
            showMessage("Enter any number, please \n");
            showMessage("Your number is integer (i) or decimal (d): \n");
            //read selection from the user
            string type = Console.ReadLine();
            //test the value type
            if (type == "i")
            {
                //declare variable
                int numberDivInt = 0;
                //show message to user
                showMessage("Enter any integer number, please \n");

                //requerid from user a number and convert in integer
                numberDivInt = Convert.ToInt32(Console.ReadLine());
                //call the method pass the user number int
                operations.Divideby(numberDivInt);

            }
            else if (type =="d")
            {
                //declare variables
                decimal numberDiv = 0;
                decimal resultDivDec = 0;
                //show message to user
                showMessage("Enter any decimal number, please \n");
                //requerid from user a number and convert in decimal
                numberDiv = Convert.ToDecimal(Console.ReadLine());
                //call the method pass the user number decimal
                operations.Divideby(numberDiv, out resultDivDec);
                //show message to user
                Console.WriteLine("The number decimal {0} divide by 2 is equals {1}", numberDiv, resultDivDec);

            }
            else
            {
                //show message to user
                showMessage("The application only works with whole numbers or decimals.");
            }

            Console.ReadLine();
        }
        public static void showMessage(string messageIn)
        {
            Console.WriteLine(messageIn);
        }
    }
}
