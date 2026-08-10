using System;


internal class Program
{
    static void Main()
    {
        /* Variables definitions*/
        string sName = "", sCourse = "", sExperience = "", sFeedback = "";
        int iPage = 0;
        bool bHelp = false;
        float fHours = 0.0f;


        /* Academy identification */
        Console.WriteLine("Academy of Learning Career College \n");
        Console.WriteLine("Student Daily Report. \n");

        /* Show the question and capture the anwser into the variables*/

        Console.WriteLine("What is your name?");
        sName = Console.ReadLine();  
        Console.WriteLine("What course are you on?");
        sCourse = Console.ReadLine();
        Console.WriteLine("What page number?");
        iPage = int.Parse(Console.ReadLine()); // casting string data to int data
        Console.WriteLine("Do you need help with anything? Please anwser \"true\" or \"false\".");
        bHelp = bool.Parse(Console.ReadLine()); // casting string data to boolean data
        Console.WriteLine("Were there any positive experiences you'd like to share?");
        sExperience = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specifics?");
        sFeedback = Console.ReadLine();
        Console.WriteLine("How many hour did you study today?");
        fHours = float.Parse(Console.ReadLine()); // casting string data to float data

        // final message 
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        Console.Read();

    }
}

