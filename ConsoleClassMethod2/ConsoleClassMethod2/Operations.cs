using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassMethod2
{
    public class Operations
    {

        public void Divideby(int dataIn)
        {
            //perform the divide operation
            int resultDivInt = dataIn / 2;
            //show message on the screen
            Console.WriteLine("The number {0} divide by 2 is equals {1}", dataIn, resultDivInt);
        }
        public void Divideby(decimal dataIn, out decimal dataOut)
        {
            //perform the divide operation
            dataOut = dataIn / 2;
        }


    }
}
