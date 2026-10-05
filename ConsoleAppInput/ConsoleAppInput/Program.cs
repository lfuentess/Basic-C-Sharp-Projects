using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //set the route of file
            string route = "C:\\Users\\lfuen\\Logs\\logUser.txt";
            //Ask the user for the number
            Console.WriteLine("Enter a number, please");
            decimal numb = Convert.ToDecimal(Console.ReadLine());
            //convert the num in string also is concatenate with another text
            string text = "The number entered is: "+ numb.ToString();
            //call method to write in the file
            WriteFile(route, text);
            //call method to read the file and show on the screen
            ReadFile(route);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }

        public static void WriteFile(string routeIn,string dataIn)
        {
            //write the file in route 
            File.WriteAllText(@routeIn, dataIn);
            Console.WriteLine("File is saved");
        }

        public static void ReadFile(string routeIn)
        {
            //read from file the text saved 
            string text = File.ReadAllText(routeIn);
            Console.WriteLine("The text in the file is: \n {0} ", text);
        
        }
    }
}
