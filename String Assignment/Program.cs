using System;
using System.Text;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string part1 = "I ";
            string part2 = "like ";
            string part3 = "c#!";

            Console.WriteLine(part1 + part2 + part3.ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append("Lorem ipsum dolor sit amet, consectetur adipiscing elit. ");
            sb.Append("Nullam egestas lacinia odio. ");
            sb.Append("Nunc sed mattis ligula, a efficitur ipsum. ");
            sb.Append("Cras vitae purus sollicitudin, porttitor leo venenatis, mattis ipsum. ");
            sb.Append("Morbi laoreet nisl a justo pharetra, vitae euismod risus pretium. ");
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
