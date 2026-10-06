using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTryCatch
{
    //class manage some exception
    //FraudException inherit from Exception
    public class FraudException :Exception
    {
        public FraudException() :base() { }
        //overload exception
        public FraudException(string message) : base(message) { }
    }
}
