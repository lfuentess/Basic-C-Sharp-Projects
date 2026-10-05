using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDatetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define current time and show it
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            //Ask the user for the number
            Console.WriteLine("Enter a number, please");
            Int32 numb = Convert.ToInt32(Console.ReadLine());
            //add the numb to the hour current
            DateTime newHour = DateTime.Now.AddHours(numb);
            //show Datetime, number of user and newhour
            Console.WriteLine("time {0} plus {1} hours, so it will be {2} ", dateTime, numb, newHour);

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
