using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructor
{
    public class Employee
    {
        public string employeeFullName {  get; set; }
        public int employeeId { get; set; }
        public Employee(string name) : this(name, 0)
        {

        }
        public Employee(string name, int id) 
        {
            employeeFullName = name;
            employeeId = id;
        }
    }
}
