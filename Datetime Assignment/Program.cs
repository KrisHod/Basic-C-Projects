using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter the number, please");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In " + hours + " hours will be " + DateTime.Now.AddHours(hours));
            Console.Read();
        }
    }
}
