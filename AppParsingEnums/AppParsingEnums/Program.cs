using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppParsingEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Require the currently day from the user
            Console.Write("Please enter the current day of the week: ");
            string dayCurr = Console.ReadLine();
            try
            {
                // Convert string data to Enum type
                dayoftheweek currentDay = (dayoftheweek)Enum.Parse(typeof(dayoftheweek), dayCurr, true);
                Console.WriteLine("You entered: {0}, the value is {1}", currentDay, (int)currentDay);
            }
            catch
            {
                // message if the value is invalid
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
        //create Enum
        enum dayoftheweek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
