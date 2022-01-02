using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    internal static class Class1
    {
        public static void DivideBy2(int a)
        {
            Console.WriteLine("Your number divided by 2 is " + a/2);
        }
        public static void DivideBy2 (int a, out int output){
        output = a/2;
        }
    }
}
