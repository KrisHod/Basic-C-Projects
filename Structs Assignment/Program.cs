using System;

namespace Structs_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Number number = new Number();
            number.Amount = 1000m;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
