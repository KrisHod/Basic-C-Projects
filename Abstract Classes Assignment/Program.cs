using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Kristina", lastName = "Hodomska" };
            employee.SayName();
            Console.Read();
        }
    }
}
