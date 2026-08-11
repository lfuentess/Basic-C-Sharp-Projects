using System;
using System.Runtime.Remoting.Lifetime;
using System.Threading.Tasks;


namespace packageexpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");// show identification program
            Console.WriteLine("Please enter the package weight:"); // Requires the user's input packet weight.
            decimal iWeight = Convert.ToDecimal(Console.ReadLine()); // convert string data to decimal data
            if (iWeight > 50) //evaluate if it is greater than 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");//send message to console and end the execution of the program
            }
            else
            {
                /* the following requires user width, height and length */
                /* convert all string data to decimal data */
                Console.WriteLine("Please enter the package width:");
                decimal iWidth = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                decimal iHeight = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                decimal iLength = Convert.ToDecimal(Console.ReadLine());

                if ((iLength + iHeight + iWidth) > 50) // evaluate if the sum of three values is greater than 50
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");// If it is larger send message to console and end the execution of the program
                }
                else
                {
                    decimal dQuote = ((iLength * iHeight * iWidth) * iWeight) / 100;//perform mathematical operations to obtain the quote to be paid by the user
                    Console.WriteLine("Your estimated total for shipping this package is: \n $" + dQuote.ToString("0.00"));// show quote to pay
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
