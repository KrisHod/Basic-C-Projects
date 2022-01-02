using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class1 class1 = new Class1();
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            //class1.DivideBy2(num);
            Class1.DivideBy2(num);

            int output = 0;
            //class1.DivideBy2(num, out output);
            Class1.DivideBy2(num, out output);
            Console.WriteLine("output parameter equals " + output);
            Console.ReadLine();

        }
    }
}
