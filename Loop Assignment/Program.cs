using System;

namespace Loop_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            while (a < 10)
            {
                Console.WriteLine("\"a\"= {0}", a);
                a++;
            }
            int b = -1;

            do{
                Console.WriteLine("\"b\"= {0}", b);
                 b--;
            }
            while (b > -10);
            Console.ReadLine();
        }
    }
}
