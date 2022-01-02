using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OverloadedMethods overloadedMethods = new OverloadedMethods();
            Console.WriteLine(overloadedMethods.addition(2));
            Console.WriteLine(overloadedMethods.addition(2M));
            Console.WriteLine(overloadedMethods.addition("2"));

            Console.Read();
        }
    }
}
