using System;
using System.IO;

namespace File_IO_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number, please");
            File.WriteAllText(@"C:\Users\Zver\Desktop\Basic_C#_Programs\Basic-C-Sharp-Projects\File IO Assignment\log.txt", Console.ReadLine());
            Console.WriteLine(File.ReadAllText(@"C:\Users\Zver\Desktop\Basic_C#_Programs\Basic-C-Sharp-Projects\File IO Assignment\log.txt"));
            Console.ReadLine();
        }
    }
}
