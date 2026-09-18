using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMainMethod
{
    public class commethods
    {
        public int multiplication(int dataIn)
        {
            return dataIn * 3;
        }
        public double multiplication(double dataIn)
        {
            return dataIn * 3;
        }
        public int multiplication(string dataIn)
        {
            return Convert.ToInt32(dataIn)*2;
        }
    }
}
