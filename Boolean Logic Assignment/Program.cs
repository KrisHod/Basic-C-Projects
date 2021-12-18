using System;

namespace Boolean_Logic_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Enter \"true\" or \"false\"");
            bool trueOrFalse = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");

            bool res = age>15 && (trueOrFalse != true) && (tickets < 3);

            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
