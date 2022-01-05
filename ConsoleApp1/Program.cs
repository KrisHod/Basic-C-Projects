using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string> { "French", "English", "Russian" } ;

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>{1, 5, 7, 8 } ;
            
            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine("**************");

            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
