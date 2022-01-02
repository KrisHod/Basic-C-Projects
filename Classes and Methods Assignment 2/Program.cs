using System;

namespace Classes_and_Methods_Assignment_2
{
    internal class Program
    {
        static void Main()
        {
            OptionalParameter optionalParameter = new OptionalParameter();
            

            Console.WriteLine("Enter one or two whole numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();

            if (input == "")
            {
                Console.WriteLine(optionalParameter.subtract(a));
            }
            else
            {
                int b = Convert.ToInt32(input);
                Console.WriteLine(optionalParameter.subtract(a, b));
            }
            Console.ReadLine();
        }
    }
}
