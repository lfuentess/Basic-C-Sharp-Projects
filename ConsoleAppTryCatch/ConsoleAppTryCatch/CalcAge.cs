using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTryCatch
{
    public class CalcAge 
    {
        //propierties Age and Year of bort
        public int Age {get;set;}
        public int Year {get;set;}

        public string AskAge() 
        {
            //valid the number entered is right or not
            bool isValid = false;
            while (!isValid) 
            {
                isValid = int.TryParse(Console.ReadLine(), out int age);
                // if the number is not right show message
                if (!isValid) Console.WriteLine("Please enter digits only more that 0, no decimal.");
                else Age = age;
                // if the value entered is menor than 1 send to Fraudexception
                if (isValid && age <= 0) throw new FraudException();
            }
            //declare var datetime and calculate the year of born and return the value of year
            var dateTime = DateTime.Now;
            Year = (dateTime.Year - Age);
            return Year.ToString();
        }
    }
}
