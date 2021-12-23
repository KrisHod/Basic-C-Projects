using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            string[] arrayString = { "Kiev", "Lisabon", "Madrid", "Lyon" };
            Console.WriteLine("select an index of the array from 0 to 3");
            int index1 = Convert.ToInt32(Console.ReadLine());
            if (index1 < arrayString.Length)
            {
                Console.WriteLine(arrayString[index1]);
            }
            else
            {
            Console.WriteLine("you selected index that doesn't exist");
            }

            int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("select an index of the array from 0 to 8");
            int index2 = Convert.ToInt32(Console.ReadLine());
            if (index1 < arrayString.Length)
            {
                Console.WriteLine(arrayInt[index2]);
            }
            else
            {
                Console.WriteLine("you selected index that doesn't exist");
            }
            Console.ReadLine();

            List<string> list = new List<string>();
            int i = 0;
            while (i < arrayString.Length) {
                list.Add(arrayString[i]);
            i++;
            }
            Console.WriteLine("select an index of the list from 0 to 3");
            int index3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(list[index3]);
            Console.ReadLine();
        }
    }
}
