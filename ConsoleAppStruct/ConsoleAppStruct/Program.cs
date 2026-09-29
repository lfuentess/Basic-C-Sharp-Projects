using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of data type Number
            Number number = new Number();
            //assign an amount to it.
            number.Amount = 23541.23M;
            //Print this amount to the console.
            Console.WriteLine("The Amount is {0}",number.Amount);
        }

        //Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
        struct Number
        { 
            public decimal Amount;
        }
    }
}
