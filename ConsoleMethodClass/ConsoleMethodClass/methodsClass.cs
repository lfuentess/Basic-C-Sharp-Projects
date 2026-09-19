using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodClass
{
    class methodsClass
    {
        public void method(int dataInA, int dataInB)
        {
            //perfom a math operation with de first number (dataInA)
            Console.WriteLine("\t First number operation: ({0} * 2)  / 4 = {1} \n", dataInA ,(dataInA * 2) / 4);
            
            //Show the second number for screen
            Console.WriteLine("\t Second number is: {0} \n", dataInB);
        }
    }
}
