using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Array of strings
            string[] stringData = new string[] {"Windows", "MacOS", "Linux", "O/S2 Warp" };// define string array and assign values
            Console.Write("Entry a number between 0 to 3:"); //show message the user
            int index;// define integer var
            do  // open loop 
            {
                try  // begin function catch errors
                {
                    index = Convert.ToInt32(Console.ReadLine()); // read entry from the user and assing to var
                }
                catch // show message of error and required a new entry
                {
                    Console.Write("Error, that value selected is invalid. Entry a number between 0 to 3:");
                    index = Convert.ToInt32(Console.ReadLine()); // read entry from the user and assing to var
                }
            }
            while (index >3 || index < 0); // validate value between range to exit 
            Console.Write(stringData[index] + "\n");// show value the stringData selected
            
        //Array 
            int[] intArray = new int[] {3,7,14,21,28};// define integer array and assign values
            Console.Write("\n Entry a number between 0 to 4:");//show message the user
            int index1;// define integer var
            do  // open loop 
            {
                try // begin function catch errors
                {
                    index1 = Convert.ToInt32(Console.ReadLine()); // read entry from the user and assing to var
                }
                catch // show message of error and required a new entry
                {
                    Console.Write("Error, that value selected is invalid. Entry a number between 0 to 4:");
                    index1 = Convert.ToInt32(Console.ReadLine()); // read entry from the user and assing to var
                }
            }
            while (index1 > 4 || index1 < 0);// validate value between range to exit
            Console.Write(intArray[index1]);// show value the stringData selected

            //List
            List<string> fruitList = new List<string>()
            {
                "Apple", "Peach", "Banana", "Mango", "Grape", "Pinapple", "Orange"
            };
            Console.Write("\n Entry a number between 0 to 6:");//show message the user

            int index2;
            do  // open loop 
            {
                try // begin function catch errors
                {
                    index2 = Convert.ToInt32(Console.ReadLine()); // read entry from the user and assing to var
                }
                catch // show message of error and required a new entry
                {
                    Console.Write("Error, that value selected is invalid. Entry a number between 0 to 6:");
                    index2 = Convert.ToInt32(Console.ReadLine()); // read entry from the user and assing to var
                }                

            } while (index2 > 6 || index2 < 0);//
            Console.Write(fruitList[index2]);// show value the stringData selected
            Console.ReadLine();
        }
    }
}
