using System;
using System.Text;

namespace StringConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sVarA="Hi!, today is a beautiful day! \n ", sVarB = " \t How are you doing? \n", sVarC = " \t \t Are you ok? \n"; // delarations variables and assign text
            string sVarD = sVarA + sVarB + sVarC; // Concatenate and assign a new variable
            Console.WriteLine(sVarD); // Display text 
            Console.WriteLine(sVarD.ToUpper()); //Display text in uppercase
            Console.WriteLine("-------------");

            StringBuilder sbVariable = new StringBuilder(); //Create a new StringBuilder variable
            sbVariable.Append(sVarA); //Add first variable
            sbVariable.Append(' '); //Add blank space 
            sbVariable.Append(sVarB);//Add second variable
            sbVariable.Append(' ');//Add blank space 
            sbVariable.Append(sVarC);//Add third variable
            sbVariable.Append(' ');//Add blank space 
            Console.WriteLine(sbVariable.ToString());//Display the StringBuilder variable

            sbVariable.Insert(0, "This go first. \n");// Insert text in the first position

            Console.WriteLine(sbVariable.ToString());// Display the StringBuilder variable

            sbVariable.Replace("Hi", "Hello"); // Change one word to another
            Console.WriteLine(sbVariable.ToString());// Display the StringBuilder variable
        }
    }
}
