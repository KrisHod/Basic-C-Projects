using System;

namespace Income_Comparison_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate?");
            double rate1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            double hours1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate?");
            double rate2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            double hours2 = Convert.ToDouble(Console.ReadLine());

            double annualSalary1 = hours1 * rate1 * 52;
            double annualSalary2 = hours2 * rate2 * 52;


            Console.WriteLine("Annual salary of Person 1: \n" + annualSalary1);
            Console.WriteLine("Annual salary of Person 2: \n" + annualSalary2);

            Console.WriteLine("Person 1 makes more money than Person 2\n" + (annualSalary1 > annualSalary2));

            Console.Read();

        }
    }
}
