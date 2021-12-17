using System;


namespace Math_Operation_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = num * 50;
            Console.WriteLine("Your number multiplied by 50 is " + res);

            Console.WriteLine("Enter one more number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int res2 = num2 + 25;
            Console.WriteLine("Your number + 25 equals " + res2);

            Console.WriteLine("Enter one more number:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double res3 = num3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + res3);

            Console.WriteLine("Enter one more number:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool isGreater = num4 > 50;
            Console.WriteLine("Is your number greater than 50? \n" + isGreater);

            Console.WriteLine("Enter one more number:");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int res4 = num5 % 7;
            Console.WriteLine("Remainder of your number divided by 7 is " + res4);
            Console.Read();
        }
    }
}
