using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Katia is ", "Lola is ", "Misha is ", "Kostya is " };
            Console.WriteLine("Enter an adjective:");
            string input1 = Console.ReadLine();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] + input1;
            }

            for (int j = 0; j <= array.Length - 1; j++)
            {
                Console.WriteLine(array[j]);
            }

            List<string> capitals = new List<string>() { "Nicosia", "London", "Paris", "Berlin", "Kiev" };
            Console.WriteLine("Enter a capital to search for in our list");
            string input2 = Console.ReadLine();
            foreach (string capital in capitals)
            {
                if (capital == input2)
                {
                    Console.WriteLine(capitals.IndexOf(capital));
                    Console.Read();
                    break;
                }

            }
            if (!capitals.Contains(input2))
            {
                Console.WriteLine("There isn't such capital in our list");
                Console.Read();
            }

            List<string> names = new List<string>() { "Boris", "Katia", "Ivan", "Eva", "Afonia", "Boris"};
            Console.WriteLine("Enter a name to search for in our list");
            string input3 = Console.ReadLine();
            Console.WriteLine(input3);
            foreach (string name in names)
            {
                if (name == input3)
                {
                    Console.WriteLine(name);
                    Console.Read();
                }
            }

            if(!names.Contains(input3)){
                Console.WriteLine("There isn't such name in our list");
                Console.Read();
            }

          
        }
    }
}
