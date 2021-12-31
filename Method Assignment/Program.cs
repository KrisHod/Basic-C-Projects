using System;

namespace Method_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());

            MathOper mathOper = new MathOper();
            Console.WriteLine(mathOper.doubleNumber(a));
            Console.WriteLine(mathOper.divideByTwo(a));
            Console.WriteLine(mathOper.increaseByTwo(a));
            Console.Read();
        }
    }
}
